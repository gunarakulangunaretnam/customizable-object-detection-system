# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: object_detection/protos/center_net.proto
"""Generated protocol buffer code."""
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


from object_detection.protos import image_resizer_pb2 as object__detection_dot_protos_dot_image__resizer__pb2
from object_detection.protos import losses_pb2 as object__detection_dot_protos_dot_losses__pb2
from object_detection.protos import post_processing_pb2 as object__detection_dot_protos_dot_post__processing__pb2
from object_detection.protos import preprocessor_pb2 as object__detection_dot_protos_dot_preprocessor__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n(object_detection/protos/center_net.proto\x12\x17object_detection.protos\x1a+object_detection/protos/image_resizer.proto\x1a$object_detection/protos/losses.proto\x1a-object_detection/protos/post_processing.proto\x1a*object_detection/protos/preprocessor.proto\"\xc2\'\n\tCenterNet\x12\x13\n\x0bnum_classes\x18\x01 \x01(\x05\x12M\n\x11\x66\x65\x61ture_extractor\x18\x02 \x01(\x0b\x32\x32.object_detection.protos.CenterNetFeatureExtractor\x12<\n\rimage_resizer\x18\x03 \x01(\x0b\x32%.object_detection.protos.ImageResizer\x12\x1c\n\ruse_depthwise\x18\r \x01(\x08:\x05\x66\x61lse\x12%\n\x16\x63ompute_heatmap_sparse\x18\x0f \x01(\x08:\x05\x66\x61lse\x12Q\n\x15object_detection_task\x18\x04 \x01(\x0b\x32\x32.object_detection.protos.CenterNet.ObjectDetection\x12S\n\x14object_center_params\x18\x05 \x01(\x0b\x32\x35.object_detection.protos.CenterNet.ObjectCenterParams\x12\x1f\n\x17keypoint_label_map_path\x18\x06 \x01(\t\x12W\n\x18keypoint_estimation_task\x18\x07 \x03(\x0b\x32\x35.object_detection.protos.CenterNet.KeypointEstimation\x12O\n\x14mask_estimation_task\x18\x08 \x01(\x0b\x32\x31.object_detection.protos.CenterNet.MaskEstimation\x12Y\n\x19\x64\x65nsepose_estimation_task\x18\t \x01(\x0b\x32\x36.object_detection.protos.CenterNet.DensePoseEstimation\x12Q\n\x15track_estimation_task\x18\n \x01(\x0b\x32\x32.object_detection.protos.CenterNet.TrackEstimation\x12Y\n\x14temporal_offset_task\x18\x0c \x01(\x0b\x32;.object_detection.protos.CenterNet.TemporalOffsetEstimation\x12Y\n\x17\x64\x65\x65pmac_mask_estimation\x18\x0e \x01(\x0b\x32\x38.object_detection.protos.CenterNet.DeepMACMaskEstimation\x12@\n\x0fpost_processing\x18\x18 \x01(\x0b\x32\'.object_detection.protos.PostProcessing\x1a\x41\n\x14PredictionHeadParams\x12\x13\n\x0bnum_filters\x18\x01 \x03(\x05\x12\x14\n\x0ckernel_sizes\x18\x02 \x03(\x05\x1a\xf4\x02\n\x0fObjectDetection\x12\x1b\n\x10task_loss_weight\x18\x01 \x01(\x02:\x01\x31\x12\x1d\n\x12offset_loss_weight\x18\x03 \x01(\x02:\x01\x31\x12\x1e\n\x11scale_loss_weight\x18\x04 \x01(\x02:\x03\x30.1\x12\x44\n\x11localization_loss\x18\x08 \x01(\x0b\x32).object_detection.protos.LocalizationLoss\x12R\n\x11scale_head_params\x18\t \x01(\x0b\x32\x37.object_detection.protos.CenterNet.PredictionHeadParams\x12S\n\x12offset_head_params\x18\n \x01(\x0b\x32\x37.object_detection.protos.CenterNet.PredictionHeadParamsJ\x04\x08\x02\x10\x03J\x04\x08\x05\x10\x06J\x04\x08\x06\x10\x07J\x04\x08\x07\x10\x08\x1a\xae\x03\n\x12ObjectCenterParams\x12$\n\x19object_center_loss_weight\x18\x01 \x01(\x02:\x01\x31\x12H\n\x13\x63lassification_loss\x18\x02 \x01(\x0b\x32+.object_detection.protos.ClassificationLoss\x12 \n\x11heatmap_bias_init\x18\x03 \x01(\x02:\x05-2.19\x12 \n\x13min_box_overlap_iou\x18\x04 \x01(\x02:\x03\x30.7\x12 \n\x13max_box_predictions\x18\x05 \x01(\x05:\x03\x31\x30\x30\x12\"\n\x13use_labeled_classes\x18\x06 \x01(\x08:\x05\x66\x61lse\x12#\n\x1bkeypoint_weights_for_center\x18\x07 \x03(\x02\x12S\n\x12\x63\x65nter_head_params\x18\x08 \x01(\x0b\x32\x37.object_detection.protos.CenterNet.PredictionHeadParams\x12$\n\x19peak_max_pool_kernel_size\x18\t \x01(\x05:\x01\x33\x1a\xb5\x0b\n\x12KeypointEstimation\x12\x11\n\ttask_name\x18\x01 \x01(\t\x12\x1b\n\x10task_loss_weight\x18\x02 \x01(\x02:\x01\x31\x12+\n\x04loss\x18\x03 \x01(\x0b\x32\x1d.object_detection.protos.Loss\x12\x1b\n\x13keypoint_class_name\x18\x04 \x01(\t\x12l\n\x15keypoint_label_to_std\x18\x05 \x03(\x0b\x32M.object_detection.protos.CenterNet.KeypointEstimation.KeypointLabelToStdEntry\x12*\n\x1fkeypoint_regression_loss_weight\x18\x06 \x01(\x02:\x01\x31\x12\'\n\x1ckeypoint_heatmap_loss_weight\x18\x07 \x01(\x02:\x01\x31\x12&\n\x1bkeypoint_offset_loss_weight\x18\x08 \x01(\x02:\x01\x31\x12 \n\x11heatmap_bias_init\x18\t \x01(\x02:\x05-2.19\x12/\n\"keypoint_candidate_score_threshold\x18\n \x01(\x02:\x03\x30.1\x12(\n\x1bnum_candidates_per_keypoint\x18\x0b \x01(\x05:\x03\x31\x30\x30\x12$\n\x19peak_max_pool_kernel_size\x18\x0c \x01(\x05:\x01\x33\x12%\n\x18unmatched_keypoint_score\x18\r \x01(\x02:\x03\x30.1\x12\x16\n\tbox_scale\x18\x0e \x01(\x02:\x03\x31.2\x12#\n\x16\x63\x61ndidate_search_scale\x18\x0f \x01(\x02:\x03\x30.3\x12,\n\x16\x63\x61ndidate_ranking_mode\x18\x10 \x01(\t:\x0cmin_distance\x12 \n\x15score_distance_offset\x18\x16 \x01(\x02:\x01\x31\x12&\n\x19score_distance_multiplier\x18\x1c \x01(\x02:\x03\x30.1\x12\x1d\n\x12std_dev_multiplier\x18\x1d \x01(\x02:\x01\x31\x12\x1d\n\x12offset_peak_radius\x18\x11 \x01(\x05:\x01\x30\x12\"\n\x13per_keypoint_offset\x18\x12 \x01(\x08:\x05\x66\x61lse\x12\x1c\n\rpredict_depth\x18\x13 \x01(\x08:\x05\x66\x61lse\x12!\n\x12per_keypoint_depth\x18\x14 \x01(\x08:\x05\x66\x61lse\x12%\n\x1akeypoint_depth_loss_weight\x18\x15 \x01(\x02:\x01\x31\x12*\n\x1b\x63lip_out_of_frame_keypoints\x18\x17 \x01(\x08:\x05\x66\x61lse\x12 \n\x11rescore_instances\x18\x18 \x01(\x08:\x05\x66\x61lse\x12\x1e\n\x13rescoring_threshold\x18\x1e \x01(\x02:\x01\x30\x12!\n\x14gaussian_denom_ratio\x18\x1f \x01(\x02:\x03\x30.1\x12$\n\x15\x61rgmax_postprocessing\x18  \x01(\x08:\x05\x66\x61lse\x12T\n\x13heatmap_head_params\x18\x19 \x01(\x0b\x32\x37.object_detection.protos.CenterNet.PredictionHeadParams\x12S\n\x12offset_head_params\x18\x1a \x01(\x0b\x32\x37.object_detection.protos.CenterNet.PredictionHeadParams\x12T\n\x13regress_head_params\x18\x1b \x01(\x0b\x32\x37.object_detection.protos.CenterNet.PredictionHeadParams\x1a\x39\n\x17KeypointLabelToStdEntry\x12\x0b\n\x03key\x18\x01 \x01(\t\x12\r\n\x05value\x18\x02 \x01(\x02:\x02\x38\x01\x1a\xbd\x02\n\x0eMaskEstimation\x12\x1b\n\x10task_loss_weight\x18\x01 \x01(\x02:\x01\x31\x12H\n\x13\x63lassification_loss\x18\x02 \x01(\x0b\x32+.object_detection.protos.ClassificationLoss\x12\x18\n\x0bmask_height\x18\x04 \x01(\x05:\x03\x32\x35\x36\x12\x17\n\nmask_width\x18\x05 \x01(\x05:\x03\x32\x35\x36\x12\x1c\n\x0fscore_threshold\x18\x06 \x01(\x02:\x03\x30.5\x12 \n\x11heatmap_bias_init\x18\x03 \x01(\x02:\x05-2.19\x12Q\n\x10mask_head_params\x18\x07 \x01(\x0b\x32\x37.object_detection.protos.CenterNet.PredictionHeadParams\x1a\x8f\x02\n\x13\x44\x65nsePoseEstimation\x12\x1b\n\x10task_loss_weight\x18\x01 \x01(\x02:\x01\x31\x12\x10\n\x08\x63lass_id\x18\x02 \x01(\x05\x12+\n\x04loss\x18\x03 \x01(\x0b\x32\x1d.object_detection.protos.Loss\x12\x15\n\tnum_parts\x18\x04 \x01(\x05:\x02\x32\x34\x12\x1b\n\x10part_loss_weight\x18\x05 \x01(\x02:\x01\x31\x12!\n\x16\x63oordinate_loss_weight\x18\x06 \x01(\x02:\x01\x31\x12#\n\x15upsample_to_input_res\x18\x07 \x01(\x08:\x04true\x12 \n\x11heatmap_bias_init\x18\x08 \x01(\x02:\x05-2.19\x1a\xc7\x01\n\x0fTrackEstimation\x12\x1b\n\x10task_loss_weight\x18\x01 \x01(\x02:\x01\x31\x12\x15\n\rnum_track_ids\x18\x02 \x01(\x05\x12\x1c\n\x0freid_embed_size\x18\x03 \x01(\x05:\x03\x31\x32\x38\x12\x18\n\rnum_fc_layers\x18\x04 \x01(\x05:\x01\x31\x12H\n\x13\x63lassification_loss\x18\x05 \x01(\x0b\x32+.object_detection.protos.ClassificationLoss\x1a}\n\x18TemporalOffsetEstimation\x12\x1b\n\x10task_loss_weight\x18\x01 \x01(\x02:\x01\x31\x12\x44\n\x11localization_loss\x18\x02 \x01(\x0b\x32).object_detection.protos.LocalizationLoss\x1a\xf6\x05\n\x15\x44\x65\x65pMACMaskEstimation\x12H\n\x13\x63lassification_loss\x18\x01 \x01(\x0b\x32+.object_detection.protos.ClassificationLoss\x12\x1b\n\x10task_loss_weight\x18\x02 \x01(\x02:\x01\x31\x12\x10\n\x03\x64im\x18\x03 \x01(\x05:\x03\x32\x35\x36\x12\x1f\n\x13pixel_embedding_dim\x18\x04 \x01(\x05:\x02\x31\x36\x12\"\n\x1a\x61llowed_masked_classes_ids\x18\x05 \x03(\x05\x12\x15\n\tmask_size\x18\x06 \x01(\x05:\x02\x33\x32\x12\x1f\n\x13mask_num_subsamples\x18\x43 \x01(\x05:\x02-1\x12\x14\n\x06use_xy\x18\x08 \x01(\x08:\x04true\x12!\n\x0cnetwork_type\x18\t \x01(\t:\x0bhourglass52\x12$\n\x16use_instance_embedding\x18\n \x01(\x08:\x04true\x12\x1d\n\x11num_init_channels\x18\x0b \x01(\x05:\x02\x36\x34\x12,\n\x1dpredict_full_resolution_masks\x18\x0c \x01(\x08:\x05\x66\x61lse\x12\"\n\x15postprocess_crop_size\x18\r \x01(\x05:\x03\x32\x35\x36\x12\x1f\n\x14max_roi_jitter_ratio\x18\x0e \x01(\x02:\x01\x30\x12S\n\x0bjitter_mode\x18\x0f \x01(\x0e\x32\x35.object_detection.protos.RandomJitterBoxes.JitterMode:\x07\x44\x45\x46\x41ULT\x12&\n\x1b\x62ox_consistency_loss_weight\x18\x10 \x01(\x02:\x01\x30\x12(\n\x1b\x63olor_consistency_threshold\x18\x11 \x01(\x02:\x03\x30.4\x12%\n\x1a\x63olor_consistency_dilation\x18\x12 \x01(\x05:\x01\x32\x12(\n\x1d\x63olor_consistency_loss_weight\x18\x13 \x01(\x02:\x01\x30\"\xfc\x01\n\x19\x43\x65nterNetFeatureExtractor\x12\x0c\n\x04type\x18\x01 \x01(\t\x12\x15\n\rchannel_means\x18\x02 \x03(\x02\x12\x14\n\x0c\x63hannel_stds\x18\x03 \x03(\x02\x12\x1b\n\x0c\x62gr_ordering\x18\x04 \x01(\x08:\x05\x66\x61lse\x12\x1c\n\ruse_depthwise\x18\x05 \x01(\x08:\x05\x66\x61lse\x12\x1b\n\x10\x64\x65pth_multiplier\x18\t \x01(\x02:\x01\x31\x12!\n\x12use_separable_conv\x18\n \x01(\x08:\x05\x66\x61lse\x12)\n\x18upsampling_interpolation\x18\x0b \x01(\t:\x07nearest')



_CENTERNET = DESCRIPTOR.message_types_by_name['CenterNet']
_CENTERNET_PREDICTIONHEADPARAMS = _CENTERNET.nested_types_by_name['PredictionHeadParams']
_CENTERNET_OBJECTDETECTION = _CENTERNET.nested_types_by_name['ObjectDetection']
_CENTERNET_OBJECTCENTERPARAMS = _CENTERNET.nested_types_by_name['ObjectCenterParams']
_CENTERNET_KEYPOINTESTIMATION = _CENTERNET.nested_types_by_name['KeypointEstimation']
_CENTERNET_KEYPOINTESTIMATION_KEYPOINTLABELTOSTDENTRY = _CENTERNET_KEYPOINTESTIMATION.nested_types_by_name['KeypointLabelToStdEntry']
_CENTERNET_MASKESTIMATION = _CENTERNET.nested_types_by_name['MaskEstimation']
_CENTERNET_DENSEPOSEESTIMATION = _CENTERNET.nested_types_by_name['DensePoseEstimation']
_CENTERNET_TRACKESTIMATION = _CENTERNET.nested_types_by_name['TrackEstimation']
_CENTERNET_TEMPORALOFFSETESTIMATION = _CENTERNET.nested_types_by_name['TemporalOffsetEstimation']
_CENTERNET_DEEPMACMASKESTIMATION = _CENTERNET.nested_types_by_name['DeepMACMaskEstimation']
_CENTERNETFEATUREEXTRACTOR = DESCRIPTOR.message_types_by_name['CenterNetFeatureExtractor']
CenterNet = _reflection.GeneratedProtocolMessageType('CenterNet', (_message.Message,), {

  'PredictionHeadParams' : _reflection.GeneratedProtocolMessageType('PredictionHeadParams', (_message.Message,), {
    'DESCRIPTOR' : _CENTERNET_PREDICTIONHEADPARAMS,
    '__module__' : 'object_detection.protos.center_net_pb2'
    # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNet.PredictionHeadParams)
    })
  ,

  'ObjectDetection' : _reflection.GeneratedProtocolMessageType('ObjectDetection', (_message.Message,), {
    'DESCRIPTOR' : _CENTERNET_OBJECTDETECTION,
    '__module__' : 'object_detection.protos.center_net_pb2'
    # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNet.ObjectDetection)
    })
  ,

  'ObjectCenterParams' : _reflection.GeneratedProtocolMessageType('ObjectCenterParams', (_message.Message,), {
    'DESCRIPTOR' : _CENTERNET_OBJECTCENTERPARAMS,
    '__module__' : 'object_detection.protos.center_net_pb2'
    # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNet.ObjectCenterParams)
    })
  ,

  'KeypointEstimation' : _reflection.GeneratedProtocolMessageType('KeypointEstimation', (_message.Message,), {

    'KeypointLabelToStdEntry' : _reflection.GeneratedProtocolMessageType('KeypointLabelToStdEntry', (_message.Message,), {
      'DESCRIPTOR' : _CENTERNET_KEYPOINTESTIMATION_KEYPOINTLABELTOSTDENTRY,
      '__module__' : 'object_detection.protos.center_net_pb2'
      # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNet.KeypointEstimation.KeypointLabelToStdEntry)
      })
    ,
    'DESCRIPTOR' : _CENTERNET_KEYPOINTESTIMATION,
    '__module__' : 'object_detection.protos.center_net_pb2'
    # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNet.KeypointEstimation)
    })
  ,

  'MaskEstimation' : _reflection.GeneratedProtocolMessageType('MaskEstimation', (_message.Message,), {
    'DESCRIPTOR' : _CENTERNET_MASKESTIMATION,
    '__module__' : 'object_detection.protos.center_net_pb2'
    # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNet.MaskEstimation)
    })
  ,

  'DensePoseEstimation' : _reflection.GeneratedProtocolMessageType('DensePoseEstimation', (_message.Message,), {
    'DESCRIPTOR' : _CENTERNET_DENSEPOSEESTIMATION,
    '__module__' : 'object_detection.protos.center_net_pb2'
    # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNet.DensePoseEstimation)
    })
  ,

  'TrackEstimation' : _reflection.GeneratedProtocolMessageType('TrackEstimation', (_message.Message,), {
    'DESCRIPTOR' : _CENTERNET_TRACKESTIMATION,
    '__module__' : 'object_detection.protos.center_net_pb2'
    # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNet.TrackEstimation)
    })
  ,

  'TemporalOffsetEstimation' : _reflection.GeneratedProtocolMessageType('TemporalOffsetEstimation', (_message.Message,), {
    'DESCRIPTOR' : _CENTERNET_TEMPORALOFFSETESTIMATION,
    '__module__' : 'object_detection.protos.center_net_pb2'
    # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNet.TemporalOffsetEstimation)
    })
  ,

  'DeepMACMaskEstimation' : _reflection.GeneratedProtocolMessageType('DeepMACMaskEstimation', (_message.Message,), {
    'DESCRIPTOR' : _CENTERNET_DEEPMACMASKESTIMATION,
    '__module__' : 'object_detection.protos.center_net_pb2'
    # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNet.DeepMACMaskEstimation)
    })
  ,
  'DESCRIPTOR' : _CENTERNET,
  '__module__' : 'object_detection.protos.center_net_pb2'
  # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNet)
  })
_sym_db.RegisterMessage(CenterNet)
_sym_db.RegisterMessage(CenterNet.PredictionHeadParams)
_sym_db.RegisterMessage(CenterNet.ObjectDetection)
_sym_db.RegisterMessage(CenterNet.ObjectCenterParams)
_sym_db.RegisterMessage(CenterNet.KeypointEstimation)
_sym_db.RegisterMessage(CenterNet.KeypointEstimation.KeypointLabelToStdEntry)
_sym_db.RegisterMessage(CenterNet.MaskEstimation)
_sym_db.RegisterMessage(CenterNet.DensePoseEstimation)
_sym_db.RegisterMessage(CenterNet.TrackEstimation)
_sym_db.RegisterMessage(CenterNet.TemporalOffsetEstimation)
_sym_db.RegisterMessage(CenterNet.DeepMACMaskEstimation)

CenterNetFeatureExtractor = _reflection.GeneratedProtocolMessageType('CenterNetFeatureExtractor', (_message.Message,), {
  'DESCRIPTOR' : _CENTERNETFEATUREEXTRACTOR,
  '__module__' : 'object_detection.protos.center_net_pb2'
  # @@protoc_insertion_point(class_scope:object_detection.protos.CenterNetFeatureExtractor)
  })
_sym_db.RegisterMessage(CenterNetFeatureExtractor)

if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _CENTERNET_KEYPOINTESTIMATION_KEYPOINTLABELTOSTDENTRY._options = None
  _CENTERNET_KEYPOINTESTIMATION_KEYPOINTLABELTOSTDENTRY._serialized_options = b'8\001'
  _CENTERNET._serialized_start=244
  _CENTERNET._serialized_end=5302
  _CENTERNET_PREDICTIONHEADPARAMS._serialized_start=1281
  _CENTERNET_PREDICTIONHEADPARAMS._serialized_end=1346
  _CENTERNET_OBJECTDETECTION._serialized_start=1349
  _CENTERNET_OBJECTDETECTION._serialized_end=1721
  _CENTERNET_OBJECTCENTERPARAMS._serialized_start=1724
  _CENTERNET_OBJECTCENTERPARAMS._serialized_end=2154
  _CENTERNET_KEYPOINTESTIMATION._serialized_start=2157
  _CENTERNET_KEYPOINTESTIMATION._serialized_end=3618
  _CENTERNET_KEYPOINTESTIMATION_KEYPOINTLABELTOSTDENTRY._serialized_start=3561
  _CENTERNET_KEYPOINTESTIMATION_KEYPOINTLABELTOSTDENTRY._serialized_end=3618
  _CENTERNET_MASKESTIMATION._serialized_start=3621
  _CENTERNET_MASKESTIMATION._serialized_end=3938
  _CENTERNET_DENSEPOSEESTIMATION._serialized_start=3941
  _CENTERNET_DENSEPOSEESTIMATION._serialized_end=4212
  _CENTERNET_TRACKESTIMATION._serialized_start=4215
  _CENTERNET_TRACKESTIMATION._serialized_end=4414
  _CENTERNET_TEMPORALOFFSETESTIMATION._serialized_start=4416
  _CENTERNET_TEMPORALOFFSETESTIMATION._serialized_end=4541
  _CENTERNET_DEEPMACMASKESTIMATION._serialized_start=4544
  _CENTERNET_DEEPMACMASKESTIMATION._serialized_end=5302
  _CENTERNETFEATUREEXTRACTOR._serialized_start=5305
  _CENTERNETFEATUREEXTRACTOR._serialized_end=5557
# @@protoc_insertion_point(module_scope)
