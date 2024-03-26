#!/usr/bin/env python
# coding: utf-8



import joblib
import pandas as pd


my_loaded_model = joblib.load("C-MAPSS1.pkl")
unitNames = ['UnitNumber']
timeCycles = ["TimeInCycles"]
sensorMes2 = ["SensorMes2"]
sensorMes3 = ["SensorMes3"]
sensorMes4 = ["SensorMes4"]
sensorMes8 = ["SensorMes8"]
sensorMes9 = ["SensorMes9"]
sensorMes10 = ["SensorMes10"]
sensorMes11 = ["SensorMes11"]
sensorMes13 = ["SensorMes13"]
sensorMes14 = ["SensorMes14"]
sensorMes16 = ["SensorMes16"]
sensorMes17 = ["SensorMes17"]
columnsNames = unitNames + timeCycles + sensorMes2 + sensorMes3 + sensorMes4 + sensorMes8 + sensorMes9 + sensorMes10 + sensorMes11 + sensorMes13 + sensorMes14 + sensorMes16 + sensorMes17
path = "C:/Users/simog/Downloads/NASA-Turbofan-Jet-Engine-RUL-prediction-C-MAPSS-main/NASA-Turbofan-Jet-Engine-RUL-prediction-C-MAPSS-main/Failure prediction/testpy.txt"
traint = pd.read_csv(path, sep=r'\s+', names=columnsNames)
MAPSS_predictions = my_loaded_model.predict(traint)
print(MAPSS_predictions)





# In[ ]:




