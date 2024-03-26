# Python script: modele_regression.py

from sklearn.linear_model import LinearRegression
import joblib


X_train = [[1], [2], [3], [4], [5]]
y_train = [2, 4, 5, 4, 5]
# Créez une instance du modèle
model = LinearRegression()

# Entraînez le modèle avec vos données
model.fit(X_train, y_train)

print ("Hello")

def say_hello():

    print ("Hello")
    return "Hello, world run!"


def test(message):
    
    return message 

# Sauvegarde du modèle
joblib.dump(model, 'modele_regression.pkl')
