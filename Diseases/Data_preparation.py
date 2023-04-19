import pandas as pd
from sklearn.preprocessing import LabelEncoder


def prepare_data_for_random_forest(BaseEstimator, TransformerMixin):
    def __init__(self, data_file):
        self.data_file = data_file

    def fit(self, X, y=None):
        return self

    def transform(self, X, y=None):
        data = pd.read_csv(self.data_file)
        symptoms_df = pd.get_dummies(data['Symptom'], prefix='Symptom')
        return symptoms_df