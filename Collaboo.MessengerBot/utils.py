from wit import Wit


access_token = 'VP44MCHYMW6ZHEJTTNC27IZAVAGGPPMO'

client = Wit(access_token = access_token)

def wit_response(msg_text):
    resp = client.message(msg_text)
    entity = None
    value = None
    try:
        entity = list(resp['entities'])[0]
        value = resp['entities'][entity][0]['value']
    except:
        pass
    return (entity, value)
