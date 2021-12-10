colors = []
labels = []



label_text_file = open('labels.txt', 'r') 
label_lines = label_text_file.readlines() 
  
color_text_file = open('colors.txt', 'r') 
color_lines = color_text_file.readlines() 

for line in label_lines:
    labels.append(line.strip())


for line in color_lines:
    colors.append(line.strip().replace(")",""))


output = ""

for x in range(80):

    output = output + f'"{labels[x]}" : "{colors[x]}", \n'

file = open("output.txt", "w")
file.write(output) 
file.close() 