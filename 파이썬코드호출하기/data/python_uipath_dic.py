import json

master = {}
master['uipath'] = {'rank' : 1, 'lastest' : '2020.4.1', 'message' : '오류'}
master['rpa'] = {'rank': 2, 'lastest': '2022.1.1', 'message': '정상'}
master['python'] = {'rank': 3, 'lastest': '2023.5.1', 'message': '정상'}
# master = {'uipath': {'rank': 1, 'lastest': '2020.4.1', 'message': '정상'}}

def greeting(key):
    '''
    함수 설명 독스트링 

    키를 입력하면 해당하는 Dictionary를 json 형식으로 반환한다. 

    if key in master:
        return json.dumps(master[key])
    else:
        return json.dumps({"message": "해당 값이 없습니다."})
    '''
    return json.dumps(master.get(key, {"message": "해당 키 값이 없습니다."}))