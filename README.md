SRP fileovi: Notebook.cs i NotebookLogger.cs

Problem je sto notebook treba i save-at podatke u notebook i cuvati kopiju samog sebe
Notebook sam rastavio na notebook memento koji cuva kopiju notebooka i na sami notebook koji sprema noteove

OCP fileovi: GraphicEditor.cs i IDrawable.cs
Metoda Draw predstavlja problem jer nije implementirana na nacin koji dopusta prosirenja, a ne zahtjeva promjene, a
to smo razrjesili uvodenjem sucelja IDrawable koje nam nalaze da svaka shape klasa treba napraviti metodu draw i onda
GraphicEditor samo koristi tu vec definiranu metodu

LSP fileovi: BankAccount.cs i IAccount.cs
Metoda Withdraw dodaje dodatnu funkciju na base verziju te metode i tu dolazi do nezeljenog ponasanja sto krsi LSP
jer klasa SavingsAccount ne moze u potpunosti zamjeniti roditeljsku (BankAccount)
To smo rijesili uvodenjem apstrakcije IAccount sa automatskim svojstvom i 2 metode Add i Withdraw

ISP fileovi: Worker.cs i IEater.cs
Problem je sto postoji klasa robot koja nasljeduje klasu worker, a robot nema potrebu za hranom i spavanjem
Problem je rijesen razdvanjanjem IWorker sucelja na vise njih specificnijih, a da klase nasljeduju samo one koje su im potrebne

DIP fileovi: Switch.cs i ISwitchable.cs
Problem je sto su klase Switch i Room u cvrstoj sprezi jer Room u sebi sadrzi instancu Switch sto nije dobro,
a to smo rijesili uvodenjem apstrakcije, koju onda dajemo klasi Room da radi s njom, tako ovise o apstrakciji, a
ne jedna o drugoj
