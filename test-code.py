import os
import six     
import cv2                                                          # To Perform OS level works.
import argparse
import collections
import numpy as np                                                         # To get arguments
import tensorflow as tf                                                 # Main Library.
from object_detection.utils import label_map_util                       # To handle label map.
from object_detection.utils import config_util                          # To load model pipeline.
from object_detection.utils import visualization_utils as viz_utils     # To draw rectangles.
from object_detection.builders import model_builder                     # To load & Build models.            

# Enable GPU dynamic memory allocation
gpus = tf.config.experimental.list_physical_devices('GPU')
for gpu in gpus:
    tf.config.experimental.set_memory_growth(gpu, True)


ap = argparse.ArgumentParser()              													# Create argparse object
ap.add_argument("-m", "--model_name", required=True, help="Name of the model") 					# Create model_name argument
ap.add_argument("-l", "--labels", required=True, help="Labels that are needed to be detected")  # Create labels argument
args = vars(ap.parse_args())                													# Build argparse

processing_type = ""          		# Store processing type.
labels = []					  		# Store Labels in a list.


model_config_path =  f'data/models/{args["model_name"]}/pipeline.config'        # Store the path of config file
checkpoint_model_path   =  f'data/models/{args["model_name"]}/checkpoint/ckpt-0'      # Store the path of model
label_map_path    =  f'data/mscoco_label_map.pbtxt'                             # Store the path of label_map

if args['labels'] == "all_labels":   

	processing_type = "all_labels"	# Change processing_type as all_labels

else:
	processing_type = "labels"      # Change as labels to perform 


if processing_type == "labels":     
	labels = args['labels'].split(",")    # Store given labels to the labels list.


# Load pipeline config and build a detection model
configs = config_util.get_configs_from_pipeline_file(model_config_path)
model_config = configs['model']
detection_model = model_builder.build(model_config=model_config, is_training=False)

# Restore checkpoint
ckpt = tf.compat.v2.train.Checkpoint(model=detection_model)
ckpt.restore(checkpoint_model_path).expect_partial()

@tf.function

def detect_fn(image):
    """Detect objects in image."""

    image, shapes = detection_model.preprocess(image)
    prediction_dict = detection_model.predict(image, shapes)
    detections = detection_model.postprocess(prediction_dict, shapes)

    return detections, prediction_dict, tf.reshape(shapes, [-1])


category_index = label_map_util.create_category_index_from_labelmap(label_map_path,
                                                                    use_display_name=True)

cap = cv2.VideoCapture(0)

STANDARD_COLORS = [
    'AliceBlue', 'Chartreuse', 'Aqua', 'Aquamarine', 'Azure', 'Beige', 'Bisque',
    'BlanchedAlmond', 'BlueViolet', 'BurlyWood', 'CadetBlue', 'AntiqueWhite',
    'Chocolate', 'Coral', 'CornflowerBlue', 'Cornsilk', 'Crimson', 'Cyan',
    'DarkCyan', 'DarkGoldenRod', 'DarkGrey', 'DarkKhaki', 'DarkOrange',
    'DarkOrchid', 'DarkSalmon', 'DarkSeaGreen', 'DarkTurquoise', 'DarkViolet',
    'DeepPink', 'DeepSkyBlue', 'DodgerBlue', 'FireBrick', 'FloralWhite',
    'ForestGreen', 'Fuchsia', 'Gainsboro', 'GhostWhite', 'Gold', 'GoldenRod',
    'Salmon', 'Tan', 'HoneyDew', 'HotPink', 'IndianRed', 'Ivory', 'Khaki',
    'Lavender', 'LavenderBlush', 'LawnGreen', 'LemonChiffon', 'LightBlue',
    'LightCoral', 'LightCyan', 'LightGoldenRodYellow', 'LightGray', 'LightGrey',
    'LightGreen', 'LightPink', 'LightSalmon', 'LightSeaGreen', 'LightSkyBlue',
    'LightSlateGray', 'LightSlateGrey', 'LightSteelBlue', 'LightYellow', 'Lime',
    'LimeGreen', 'Linen', 'Magenta', 'MediumAquaMarine', 'MediumOrchid',
    'MediumPurple', 'MediumSeaGreen', 'MediumSlateBlue', 'MediumSpringGreen',
    'MediumTurquoise', 'MediumVioletRed', 'MintCream', 'MistyRose', 'Moccasin',
    'NavajoWhite', 'OldLace', 'Olive', 'OliveDrab', 'Orange', 'OrangeRed',
    'Orchid', 'PaleGoldenRod', 'PaleGreen', 'PaleTurquoise', 'PaleVioletRed',
    'PapayaWhip', 'PeachPuff', 'Peru', 'Pink', 'Plum', 'PowderBlue', 'Purple',
    'Red', 'RosyBrown', 'RoyalBlue', 'SaddleBrown', 'Green', 'SandyBrown',
    'SeaGreen', 'SeaShell', 'Sienna', 'Silver', 'SkyBlue', 'SlateBlue',
    'SlateGray', 'SlateGrey', 'Snow', 'SpringGreen', 'SteelBlue', 'GreenYellow',
    'Teal', 'Thistle', 'Tomato', 'Turquoise', 'Violet', 'Wheat', 'White',
    'WhiteSmoke', 'Yellow', 'YellowGreen'
]


while True:
    # Read frame from camera
    ret, image_np = cap.read()

    # Expand dimensions since the model expects images to have shape: [1, None, None, 3]
    image_np_expanded = np.expand_dims(image_np, axis=0)

    # Things to try:
    # Flip horizontally
    # image_np = np.fliplr(image_np).copy()

    # Convert image to grayscale
    # image_np = np.tile(
    #     np.mean(image_np, 2, keepdims=True), (1, 1, 3)).astype(np.uint8)

    input_tensor = tf.convert_to_tensor(np.expand_dims(image_np, 0), dtype=tf.float32)
    detections, predictions_dict, shapes = detect_fn(input_tensor)

    label_id_offset = 1
    image_np_with_detections = image_np.copy()

    min_score_thresh = 0.50

    box_to_display_str_map = collections.defaultdict(list)
    box_to_color_map = collections.defaultdict(str)

    for i in range(detections['detection_boxes'][0].numpy().shape[0]):

    	if detections['detection_scores'][0].numpy() is None or detections['detection_scores'][0].numpy()[i] > min_score_thresh:

    		box = tuple(detections['detection_boxes'][0].numpy()[i].tolist())

    		display_str = ''
    		
    		if (detections['detection_classes'][0].numpy() + label_id_offset).astype(int)[i] in six.viewkeys(category_index):
    			
    			class_name = category_index[(detections['detection_classes'][0].numpy() + label_id_offset).astype(int)[i]]['name']

    			display_str = '{}'.format(class_name) # round(100*detections['detection_scores'][0].numpy()[i] If you want the detection score

    			box_to_display_str_map[box].append(display_str)

    			box_to_color_map[box] = STANDARD_COLORS[(detections['detection_classes'][0].numpy() + label_id_offset).astype(int)[i] % len(STANDARD_COLORS)] #BoxColor



    im_width, im_height = image_np.shape[1::-1]

    for box, color in box_to_color_map.items():
    	ymin, xmin, ymax, xmax = box

    	ymin = ymin * im_height
    	xmin = xmin * im_width
    	ymax = ymax * im_height
    	xmax = xmax * im_width

    	x = xmin
    	y = ymin
    	w = xmax - xmin
    	h = ymax - ymin

    	if box_to_display_str_map[box][0] in labels:

    		#box_to_display_str_map[box][0] Label Name
            #color (we are getting the color) but, we dont use it

            cv2.rectangle(image_np_with_detections, (int(x),int(y)), (int(x) + int(w), int(y) + int(h)), (0,0,255), 4)
            cv2.putText(image_np_with_detections, f'{box_to_display_str_map[box][0]}', (int(x), int(y)-10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (255,0,0), 2)


    # Display output
    cv2.imshow('object detection', cv2.resize(image_np_with_detections, (800, 600)))

    if cv2.waitKey(25) & 0xFF == ord('q'):
        break 

cap.release()
cv2.destroyAllWindows()



