import numpy as np
import pandas as pd
from sklearn.ensemble import RandomForestClassifier


def main():
    # Load the dataset
    data = pd.read_csv('D:\Dataset\Diseases Symptoms.csv')

    # Create a list of all the unique symptoms
    all_symptoms = [col for col in data.columns if col != 'Disease']

    # Convert the symptom columns to dummy variables
    data = pd.get_dummies(data, columns=all_symptoms)

    # Get the list of symptom dummy variable names
    symptom_names = [col for col in data.columns if col.startswith('Symptom_')]

    # Split the dataset into features and labels
    X = data[symptom_names].values
    y = data['Disease'].values

    # Create a random forest classifier with 100 trees
    rfc = RandomForestClassifier(n_estimators=100)

    # Train the random forest classifier
    rfc.fit(X, y)

    # Get input symptoms from user
    input_symptoms = input("Enter your symptoms separated by commas: ").split(',')

    # Create an input vector with zeros and ones corresponding to the presence of each symptom
    input_values = np.zeros(X.shape[1])
    for symptom in input_symptoms:
        if 'Symptom_' + symptom in symptom_names:
            input_values[symptom_names.index('Symptom_' + symptom)] = 1

    # Make predictions on the input symptoms
    predictions = rfc.predict([input_values])

    # Get the list of potential diseases
    potential_diseases = np.unique(y[y == predictions[0]])

    # Print the list of potential diseases
    print("Potential diseases based on your symptoms:", potential_diseases)

if __name__ == '__main__':
    main()