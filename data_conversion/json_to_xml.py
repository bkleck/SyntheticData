import os
import json as j
import xml.etree.cElementTree as e
from PIL import Image 
import math
import logging

# user input main folder and list all folders inside
main_path = input('Enter folder path here:')
outer_folders = os.listdir(main_path)

# function to convert all PNG images to JPG
def image_convertor(outer_folders):

    for folder in outer_folders:
        inner_folders = os.listdir(folder)

        # get the folder with name starting with RGB
        result = str([i for i in inner_folders if i.startswith('RGB')][0])

        # get path to RGB folder
        folder_to_open = folder + '/' + result

        # make image folder
        img_path = main_path + '/' + folder + '/images'
        try:
            os.mkdir(img_path)
        except FileExistsError:
            # directory already exists
            pass

        for file in os.listdir(folder_to_open): 
            # open each file ending with PNG
            if file.endswith(".png"): 
                img = Image.open(folder_to_open + '/' + file)
                # convert RGBA to RGB
                rgb_img = img.convert('RGB')
                file_name, file_ext = os.path.splitext(file)

                # save each new image to images folder with .JPG
                # save with top folder name
                file_name = '{}_{}'.format(folder, file_name)
                rgb_img.save('{}/{}.jpg'.format(img_path, file_name))
    
        logging.info(f'Done with {folder} folder!')


# call PNG to JPG function
logging.info('Start image conversion from PNG to JPG./t')
image_convertor(outer_folders)
logging.info('/tFinished image conversion pipeline./t/t')