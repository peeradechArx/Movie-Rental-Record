# MovieRentalRecord
ความเป็นมาของโปรเเกรม

      ถ้าพูดถึงการดูหนังภาพยนตร์ที่บ้านสมัยก่อนคงถึงนึกเป็นอะไรไปไม่ได้ คือการเช่าหนัง ซึ่งมันทำให้ผมนั้นนึกคิดถึงเมื่อสมัยก่อนขึ้นมาจึงอยากลองทำโปรเเกรมนี้
วัตถุประสงค์ของโปรแกรม

       สร้างขึ้นเพื่อบันทึกการเช่าหนังในเเต่ละเดือน
Class diagram
```mermaid
classDiagram
  direction LR
  class form1{
  login()
  logout()
  }
  class logout{
  close()
  }
  class form3{
  -number
  -nameMovie
  -day
  -month
  add()
  }
  
  class FileRecordmovie{
  -
  open()
  save()
  }
  class openRecordmovie{
  -location file
  open file()
  }
  class saveRecordmovie{
  -location file
  save file()
  }
  saveRecordmovie --|> FileRecordmovie
  openRecordmovie --|> FileRecordmovie
 
  
  FileRecordmovie --|> form3
  form3 --|> form1
  logout --|> form1
  ```

**ผู้พัฒนาโปรแกรม**
```643450082-4 นาย พีระเดช โพธิ์หล้า```
       
