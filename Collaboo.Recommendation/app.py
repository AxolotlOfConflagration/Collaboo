from flask import Flask
from recommender import Recommender
import json

app = Flask(__name__)
rc = Recommender()

@app.route('/')
def hello():
    return 'Hello, World!'

@app.route('/mpl', methods=['GET'])
def mpl():
    input_ = rc.mpl()
    json_data = json.dumps(input_)
    return json_data

@app.route('/ppu/<int:user_id>', methods=['GET'])
def ppu(user_id):
    input_ = rc.ppu(user_id)[:5].tolist()
    json_data = json.dumps(input_)
    return json_data

@app.route('/usp/u/<int:user_id>', methods=['GET'])
def uspu(user_id):
    l = []
    while(len(l)<=3):
        input_ = rc.usp_(user_id, 'u')
        try:
            l = input_[1]
            if type(l) == int:
                l = []
        except TypeError:
            input_ = rc.usp_(user_id, 'u')
    json_data = json.dumps(input_)
    return json_data

@app.route('/usp/p/<int:user_id>', methods=['GET'])
def uspp(user_id):
    l = []
    while(len(l)<=3):
        input_ = rc.usp_(user_id, 'p')
        try:
            l = input_[1]
            if type(l) == int:
                l = []
        except TypeError:
            input_ = rc.usp_(user_id, 'p')
    json_data = json.dumps(input_)
    return json_data

if __name__ == '__main__':
    app.run(debug=True)
