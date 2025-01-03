﻿
연결 프로세스의 화면을 분석해서 키보드나 마우스 이벤트 반복

![picture](/Release/Resource/capture.png)
![picture](/Release/Resource/capture_eng.png)


다운로드 : https://github.com/EomTaeWook/EmulatorMacro/releases


개발환경

    WPF, C#, .net 4.8.1

    UI toolkit : MahApps.metro
    
OS 버전

    Window 8.0 이상

주의 사항

	1.Macro 실행시 앱플레이어 이미지에 여백이 발생하는 경우

		- Datas\ApplicationData.json => IsDynamic [true][false]를 변경하시면 됩니다.

	2.주 모니터 확대 비율이 더 높아야합니다.

		-주 모니터 DPI 100% 보조 모니터 150%인 경우에 대해선 기능을 처리 하지 않았습니다. 주 모니터 150%, 보조 모니터 100% 이런 식이 되어야 합니다.

    3.실행시 체크 박스가 활성화 된 트리거들만 작동됩니다.

    4.해당 이미지를 클릭을 하지 않는 경우 관리자 권한으로 실행해보세요.(제보 감사합니다)

사용 방법
    
    1.트리거 저장

        1.1 화면 캡쳐 버튼를 통하여 찾고 싶은 이미지 캡쳐
    
        1.2 Image, Mouse, Keyboard, RelativeToImage 이벤트 선택
    
            1.2.1 Image : 찾은 이미지를 클릭합니다.
                
                - 찾은 이미지 내에서 랜덤 클릭합니다.(좌표 패턴화 되는 것을 방지합니다.)

                - 고정된 좌표를 클릭하는 마우스 이벤트보다 우선시 해주세요.

            1.2.2 Mouse : 좌표 지정(좌클릭, 우클릭, 드래그) 해주시면 됩니다.
        
            1.2.3 Keyboard : Ctrl + c + v 이런식으로 조합키를 넣어주면 됩니다.

            1.2.4 RelativeToImage : 찾은 이미지로부터 +- 한 거리를 클릭합니다.(아이디어 Ko9ma7 제공)
            
            1.2.5 물리 클릭 : 마우스가 직접 이동하여 해당 위치를 클릭합니다.(아이디어 Ko9ma7 제공)
        
        1.3 실행시 이미지를 캡쳐할 실행 프로세스를 선택하시면 됩니다.

        1.4 후 작업 딜레이

            - 현재 작업이 완료 이후 어느 정도 대기를 한 후 다음 작업을 하고 싶은 경우에 사용하시면 됩니다.(아이디어 Ko9ma7 제공)

            - ex> 버튼 클릭 => 팝업 뜨기까지 대기 => 확인 버튼 클릭 (연계하는 경우)

        1.5 아이템 반복
        
            - 한번 : 한번만 발생합니다.

            - 횟수 : 횟수만큼 반복 실행합니다.

            - 검색 결과가 없을 때까지 : 하위 아이템 하나라도 실행이 된다면 반복해서 실행됩니다.(하나라도 실행이 안되면 다음 Item으로 넘어갑니다.)

            - 검색 이미지를 찾을 때까지 : 상위 이미지를 찾을때까지 하위 이벤트를 반복 실행합니다.(상위 아이템을 발견시 다음 Item으로 넘어갑니다.)

        1.6.바로가기(아이디어 Ko9ma7 제공)

            - 입력된 이벤트로 바로 이동합니다.

        1.7 저장

    2.드래그 앤 드랍으로 트리 노드 순서도 변경

        2.1 상위 아이템 밑으로 드래그 앤 드랍시 자식 노드로 추가

        2.2 자식 아이템을 상위 아이템 포커싱 밖으로 드래그 앤 드랍시 최상위 노드로 추가

            - 우측 스크롤 쪽 또는 제일 하단 또는 트리 컬럼 쪽

    3.여러 게임의 세이브 파일을 저장하고 싶은 경우 setting에서 세이브 경로를 다르게 하여 저장하세요.

    4.연결 프로세스 리스트 
        
        - 프로세스가 목록에 없는 경우 또는 종료되거나 새로운 프로세스를 실행 시켰을시엔 새로고침 버튼을 눌러주세요.

        - 연결 프로세스를 고정하게 되면 save된 프로세스 이름으로 전체를 검색하는 것이 아닌 고정된 프로세스에서만 검색하게 됩니다.(녹스 여러개 대응)    

    

※ 이미지 조합을 통한 이벤트 발생 방법

![picture](/Release/Resource/imageCombination.png)

설정(Config.json 혹은 프로그램 내 Setting)

    1.Language 언어 : [Eng],[Kor]
    
    2.SavePath : 설정 리스트 save 경로
    
    3.ProcessPeriod : 전체 작업 완료 이후 딜레이

        - 기본 값 : 1ms(0.001초)

    4.ItemDelay : 트리거 아이템 작업 완료 다음 작업까지 딜레이(공통)

        - 기본 값 : 0ms(0초)
    
    5.Similarity : 이미지 프로세싱 유사도

    6.SearchResultDisplay : [true],[false] : 이미지 검색 결과 표시 여부

    7.VersionCheck : [true],[false] : 프로그램 실행시 버전 체크 확인

    8.프로세스 위치 이동 : 해당 프로세스를 해당 좌표로 이동시킵니다. 즉 모니터 밖으로 프로세스 위치를 이동시키는 것이 가능합니다.


버그 레포팅

    enter0917@naver.com
