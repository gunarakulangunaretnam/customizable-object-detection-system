import os
import shutil
import argparse
import requests
from tqdm import tqdm

ap = argparse.ArgumentParser()
ap.add_argument("-u", "--url", required=True, help="URL of the file")
args = vars(ap.parse_args())


def create_directory(target_url):
    folder_name = target_url.split("/")
    folder_name = folder_name[-1].split(".")[0]

    dirpath = os.path.join('data/models', folder_name)

    if os.path.exists(dirpath) and os.path.isdir(dirpath):
        shutil.rmtree(dirpath)

    os.mkdir(f'data/models/{folder_name}')


create_directory(args["url"])


def download(url: str, fname: str):
    resp = requests.get(url, stream=True)
    total = int(resp.headers.get('content-length', 0))
    with open(fname, 'wb') as file, tqdm(
        desc=fname,
        total=total,
        unit='iB',
        unit_scale=True,
        unit_divisor=1024,
    ) as bar:
        for data in resp.iter_content(chunk_size=1024):
            size = file.write(data)
            bar.update(size)

            
#download("http://download.tensorflow.org/models/object_detection/tf2/20200711/ssd_mobilenet_v2_320x320_coco17_tpu-8.tar.gz", "model12")