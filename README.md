C# 개발 Repository 입니다.

-현재 접근 c# 개발자

 ->김효동 대리.
 
 ->이서정 사원(20170303)
 
[17.03.08] 

-Test용 RestAPI 프로젝트 작업 중입니다...
 
 -> Test() 메소드 통해 GET, UPDATE, CREATE, DELETE 기능 테스트는 완료했으나 메뉴얼 작성을 위해 약간의 정리가 필요합니다.

 [17.03.14] 

 - 개발 UI 
  
  1) 사원관리 UI - 김효동 대리
  
  2) 프로젝트 관리 UI - 이서정 사원
  
  3) 식권 구매 관리 UI - 윤석완 대리

- RestAPI Manual.pdf 추가.  
  
  
  
[17.03.26]
Date Type 속성 java <-> c# 간 호환 작업 진행.
-   "enteringDate": "2017-03-26T12:47:37.093Z", <-string 으로 인식.

C#에서 URL로 업데이트, 생성 작업시 입력 방법 : dateValue.ToUniversalTime().ToString("s") + "Z",

C#에서 날짜 값 사용시 Convert.ToDateTime(enteringDate) 하면됨.