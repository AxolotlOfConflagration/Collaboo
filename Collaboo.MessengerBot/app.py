import os, sys
from flask import Flask, request
from pymessenger import Bot
from utils import wit_response

TOKEN = 'EAAH9TA0EJ5gBAOQ6WXS8rwum8ZCBkN8EstvKYY1ncOjlVU7dQO4dQikbCSsemHZA88aluF7VCE1l4ZBg4ZAw7BJNU7nBDKpLnfocaZBM73kOMSxiII2p3ccmOG8gDF82AbYerE5pVZA8bJm9UZBBEZBZAJA2FvcGnnlobVv1QuLvkHMaaEStLmk3V'

app = Flask(__name__)
bot = Bot(TOKEN)

@app.route('/', methods=['GET'])
def verify():
    if request.args.get("hub.mode") == "subscribe" and request.args.get("hub.challenge"):
        if not request.args.get("hub.verify_token") == "hello":
            return "Verification token mismatch", 403
        return request.args["hub.challenge"], 200
    return "Hello world", 200


@app.route('/', methods=['POST'])
def webhook():
    data = request.get_json() 
    log(data)

    if data['object'] == 'page':
        for entry in data['entry']:
            for msg_event in entry['messaging']:
                sender_id = msg_event['sender']['id']
                recipient_id = msg_event['recipient']['id']
                if msg_event.get('message'):
                    if 'text' in msg_event['message']:
                        msg_text = msg_event['message']['text']
                    else:
                        msg_text = 'no text'
                    response = None
                    entity, value = wit_response(msg_text)
                    print(entity)
                    if entity == "infotype":
                        response = "Collaboo is an application that helps contribute to opensource projects. It helps in managing project. Our recommendation engine helps YOU to choose project that fits you based on your skillset. For more information visit: https://github.com/AxolotlOfConflagration/Collaboo"
                    elif entity == "welcome":
                        response = "Welcome to our project aggregating open-source projects and gathering programmers for a noble purpose. Ask me about project info for more! Learn more about open-source!"
                    elif entity == "opensource":
                        response = "Open-source software (OSS) is a type of computer software in which source code is released under a license in which the copyright holder grants users the rights to study, change, and distribute the software to anyone and for any purpose. Open-source software may be developed in a collaborative public manner. According to scientists who have studied it, open-source software is a prominent example of open collaboration. The term is often written without a hyphen as \"open source software\"." 
                    elif response == None:
                        response = "Sorry I don't understand"
                    bot.send_text_message(sender_id, response)

    return "ok", 200

def log(message):
    print(message)
    sys.stdout.flush()

if __name__ == "__main__":
    app.run(debug = True, port=80)
