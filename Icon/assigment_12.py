import cv2
import numpy as np

img = cv2.imread(r'2.png', 0)
goc = img.copy()
img = cv2.resize(img, (300, 300))
img = 255 - img

# kernel = np.ones((4,4),np.uint8)
#
# for i in range (0,20):
# opening = cv2.morphologyEx(img, cv2.MORPH_OPEN, kernel)

kernel = np.ones((2,2),np.uint8)
erosion = cv2.erode(img,kernel,iterations = 10)
kernel = np.ones((4,4),np.uint8)
for i in range (0,5):
opening = cv2.morphologyEx(img, cv2.MORPH_OPEN, kernel)
kernel = np.ones((2, 2), np.uint8)
dilation = cv2.dilate(erosion,kernel,iterations = 1)

th2 = cv2.adaptiveThreshold(dilation, 255, cv2.ADAPTIVE_THRESH_MEAN_C, cv2.THRESH_BINARY, 11, 5)
th3 = cv2.adaptiveThreshold(dilation, 255, cv2.ADAPTIVE_THRESH_GAUSSIAN_C, cv2.THRESH_BINARY, 11, 5)
ret4, th4 = cv2.threshold(img, 0, 255, cv2.THRESH_BINARY + cv2.THRESH_OTSU)


kernel = np.ones((2,2),np.uint8)
erosion = cv2.erode(th4,kernel,iterations = 10)
kernel = np.ones((4,4),np.uint8)
for i in range (0,5):
opening = cv2.morphologyEx(img, cv2.MORPH_OPEN, kernel)
kernel = np.ones((2, 2), np.uint8)
dilation = cv2.dilate(erosion,kernel,iterations = 1)
opening = cv2.morphologyEx(dilation, cv2.MORPH_OPEN, kernel, iterations=1)
close = cv2.morphologyEx(opening, cv2.MORPH_CLOSE, kernel, iterations=2)

cv2.imshow('th2', th2)


Cell_count, x_count, y_count = [], [], []

# hough transform with modified circular parameters
circles = cv2.HoughCircles(dilation, cv2.HOUGH_GRADIENT, 1, 15,
param1=5, param2=5, minRadius=5, maxRadius=20)

# circle detection and labeling using hough transformation
if circles is not None:
# convert the (x, y) coordinates and radius of the circles to integers
circles = np.round(circles[0, :]).astype("int")

# loop over the (x, y) coordinates and radius of the circles
for (x, y, r) in circles:
cv2.circle(erosion, (x, y), r, (255, 255, 255), 1)
cv2.rectangle(erosion, (x - 2, y - 2),
(x + 2, y + 2), (0, 128, 255), -1)
Cell_count.append(r)
x_count.append(x)
y_count.append(y)
# show the output image
cv2.imshow("gray", erosion)
print(len(Cell_count))

# cv2.imshow('erosion', dilation)
cv2.imshow('th2', th2)
cv2.imshow('th4', th4)
cv2.imshow('goc', img)
print(len(Cell_count))
cv2.waitKey(0)