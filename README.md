## Sticky note
### ความเป็นมาของโปรแกรม
อยากลองทำโปรแกรมจดโน๊ตขึ้นมาใช้เองบางคนก็อาจจะเคยใช้โปรแกรม sti

<br/><br/>
### วัตถุประสงค์ของโปรแกรม


<br/><br/>
### โครงสร้างของโปรแกรม
```mermaid
classDiagram
    Program <|-- Note
    Program <|-- searchNote
    Program : +Main()
    class Note{
        +String FNcsv
        +String pathNote
        +readNote(String filename)
        +saveNote(String filename, String title, String text)
        +deleteNote(String filename)
    }
    class searchNote{
        +showHistory()
    }
```
<br/><br/>
### ผู้พัฒนาโปรแกรม
น.ส.พรธิตา ขานพล  643450080-8                                                                                             
