import pandas as pd
from sklearn.model_selection import train_test_split
from tensorflow.keras.models import Sequential, load_model
from tensorflow.keras.layers import Dense
from sklearn.metrics import accuracy_score

# update the path of the dataset file
df = pd.read_csv('D:\Dataset\dataset.csv')

# create column names with 'Symptom_' prefix and a number from 1 to 17
symptom_cols = ['Symptom_' + str(i) for i in range(1, 18)]

# replace the 'Symptom' column with the new columns
X = pd.concat([pd.get_dummies(df.drop(['Symptom', 'Disease'], axis=1)), pd.get_dummies(df['Symptom']).rename(columns=dict(zip(df['Symptom'].unique(), symptom_cols)))], axis=1)

# create a new target variable that corresponds to the 'Disease' column
y = pd.get_dummies(df['Disease'])

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=.2)

model = Sequential()
model.add(Dense(units=32, activation='relu', input_dim=len(X_train.columns)))
model.add(Dense(units=64, activation='relu'))
model.add(Dense(units=1, activation='sigmoid'))

model.compile(loss='binary_crossentropy', optimizer='sgd', metrics='accuracy')

model.fit(X_train, y_train, epochs=200, batch_size=32)

y_hat = model.predict(X_test)
y_hat = [0 if val < 0.5 else 1 for val in y_hat]

acc = accuracy_score(y_test.values.argmax(axis=1), y_hat)
print(f"Accuracy: {acc}")