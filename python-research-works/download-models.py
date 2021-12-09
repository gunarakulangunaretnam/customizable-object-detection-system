import os
import time
import shutil
import tarfile
import argparse
import requests
from tqdm import tqdm

ap = argparse.ArgumentParser()
ap.add_argument("-u", "--url", required=True, help="URL of the file")
args = vars(ap.parse_args())

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

def create_directory(target_url):

    file_name = target_url.split("/")[-1]
    directory_structure_path = f'data/models/{file_name}'
    download(target_url, directory_structure_path)

    file = tarfile.open(directory_structure_path)

    # extracting file
    file.extractall(f'data/models/')
    file.close()

    if os.path.exists(directory_structure_path):
        os.remove(directory_structure_path)  # Delete config folder


create_directory(args["url"])
