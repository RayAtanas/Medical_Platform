import pandas as pd
from sklearn.ensemble import RandomForestClassifier
from sklearn.preprocessing import LabelEncoder

from Data_preparation import prepare_data_for_random_forest

# Load and prepare the data using the prepare_data_for_random_forest function
features, labels, valid_symptoms = prepare_data_for_random_forest('D:\Dataset\dataset.csv')

# Train a random forest classifier on the data
rfc = RandomForestClassifier(n_estimators=100, random_state=42)
rfc.fit(features, labels)

def predict_diseases(symptoms, features, rfc):
    # Get the list of valid symptoms from the prepare_data_for_random_forest function
    _, _, valid_symptoms = prepare_data_for_random_forest('D:\Dataset\dataset.csv')

    # Check that all input symptoms are valid
    valid_input_symptoms = list(set(symptoms) & set(valid_symptoms))
    invalid_symptoms = set(symptoms) - set(valid_symptoms)
    if invalid_symptoms:
        print(f"Invalid symptoms: {invalid_symptoms}.")
        print(f"Valid symptoms: {valid_symptoms}.")
        return None

    input_symptoms = pd.DataFrame([valid_input_symptoms], columns=[f'Symptom_{i}' for i in range(len(valid_input_symptoms))])
    input_symptoms = pd.get_dummies(input_symptoms.astype(str))

    # Match the column names of the input dataframe with the prepared features dataframe
    input_symptoms = input_symptoms.reindex(columns=features.columns, fill_value=0)

    # Make a prediction using the random forest model
    prediction = rfc.predict(input_symptoms)

    return prediction.tolist()


