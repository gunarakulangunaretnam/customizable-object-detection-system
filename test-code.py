import os                                                               # To Perform OS level works.
import argparse                                                         # To get arguments
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


model_config_path =  f'data/models/{args['model_name']}/pipeline.config'
checkpoint_path   =  f'data/models/{args['model_name']}/checkpoint/ckpt-0'
label_map_path    =  f'data/mscoco_label_map.pbtxt'

if args['labels'] == "all_labels":   

	processing_type = "all_labels"	# Change processing_type as all_labels

else:
	processing_type = "labels"      # Change as labels to perform 


if processing_type == "labels":     
	labels = args['labels'].split(",")    # Store given labels to the labels list.





