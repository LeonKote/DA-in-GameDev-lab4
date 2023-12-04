# АНАЛИЗ ДАННЫХ И ИСКУССТВЕННЫЙ ИНТЕЛЛЕКТ [in GameDev]
Отчет по лабораторной работе #4 выполнил(а):
- Папушев Роман Олегович
- РИ220947
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | * | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

Структура отчета

- Данные о работе: название работы, фио, группа, выполненные задания.
- Цель работы.
- Задание 1.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 2.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 3.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Выводы.
- ✨Magic ✨

## Цель работы
Научиться работать с перцептроном

## Задание 1
### В проекте Unity реализовать перцептрон, который умеет производить вычисления:
#### - OR | дать комментарии о корректности работы
#### - AND | дать комментарии о корректности работы
#### - NAND | дать комментарии о корректности работы
#### - XOR | дать комментарии о корректности работы

#### OR

| In 1 | In 2 | Out | 
| --- | --- | --- |
| 0 | 0 | 0 |
| 1 | 0 | 1 |
| 0 | 1 | 1 |
| 1 | 1 | 1 |

- В результате работы на 5 эпоху перцептрон выдаёт результаты без ошибок.

```

W1: -0,189287543296814 W2: -0,935906410217285 B: -0,0914856195449829
W1: 0,810712456703186 W2: -0,935906410217285 B: 0,908514380455017
W1: 0,810712456703186 W2: 0,0640935897827148 B: 1,90851438045502
W1: 0,810712456703186 W2: 0,0640935897827148 B: 1,90851438045502
TOTAL ERROR: 2
W1: 0,810712456703186 W2: 0,0640935897827148 B: 0,908514380455017
W1: 0,810712456703186 W2: 0,0640935897827148 B: 0,908514380455017
W1: 0,810712456703186 W2: 0,0640935897827148 B: 0,908514380455017
W1: 0,810712456703186 W2: 0,0640935897827148 B: 0,908514380455017
TOTAL ERROR: 1
W1: 0,810712456703186 W2: 0,0640935897827148 B: -0,0914856195449829
W1: 0,810712456703186 W2: 0,0640935897827148 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: 0,908514380455017
W1: 0,810712456703186 W2: 1,06409358978271 B: 0,908514380455017
TOTAL ERROR: 2
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
TOTAL ERROR: 1
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
TOTAL ERROR: 0
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
TOTAL ERROR: 0
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
TOTAL ERROR: 0
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
W1: 0,810712456703186 W2: 1,06409358978271 B: -0,0914856195449829
TOTAL ERROR: 0
Test 0 0: 0
Test 0 1: 1
Test 1 0: 1
Test 1 1: 1

```

#### AND

| In 1 | In 2 | Out | 
| --- | --- | --- |
| 0 | 0 | 0 |
| 1 | 0 | 0 |
| 0 | 1 | 0 |
| 1 | 1 | 1 |

- В результате работы на 6 эпоху перцептрон выдаёт результаты без ошибок, что несколько дольше, чем с OR.

```

W1: 0,980333089828491 W2: 0,373291701078415 B: -0,512642383575439
W1: -0,0196669101715088 W2: 0,373291701078415 B: -1,51264238357544
W1: -0,0196669101715088 W2: 0,373291701078415 B: -1,51264238357544
W1: 0,980333089828491 W2: 1,37329170107841 B: -0,512642383575439
TOTAL ERROR: 2
W1: 0,980333089828491 W2: 1,37329170107841 B: -0,512642383575439
W1: -0,0196669101715088 W2: 1,37329170107841 B: -1,51264238357544
W1: -0,0196669101715088 W2: 1,37329170107841 B: -1,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -0,512642383575439
TOTAL ERROR: 2
W1: 0,980333089828491 W2: 2,37329170107841 B: -0,512642383575439
W1: -0,0196669101715088 W2: 2,37329170107841 B: -1,51264238357544
W1: -0,0196669101715088 W2: 1,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -1,51264238357544
TOTAL ERROR: 3
W1: 0,980333089828491 W2: 2,37329170107841 B: -1,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -1,51264238357544
W1: 0,980333089828491 W2: 1,37329170107841 B: -2,51264238357544
W1: 1,98033308982849 W2: 2,37329170107841 B: -1,51264238357544
TOTAL ERROR: 2
W1: 1,98033308982849 W2: 2,37329170107841 B: -1,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
TOTAL ERROR: 1
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
TOTAL ERROR: 0
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
TOTAL ERROR: 0
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
W1: 0,980333089828491 W2: 2,37329170107841 B: -2,51264238357544
TOTAL ERROR: 0
Test 0 0: 0
Test 0 1: 0
Test 1 0: 0
Test 1 1: 1

```

#### NAND

| In 1 | In 2 | Out | 
| --- | --- | --- |
| 0 | 0 | 1 |
| 1 | 0 | 1 |
| 0 | 1 | 1 |
| 1 | 1 | 0 |

- Так же, как и с AND, в результате работы на 6 эпоху перцептрон выдаёт результаты без ошибок.

```

W1: 0,283797711133957 W2: 0,346789568662643 B: 0,308544129133224
W1: 0,283797711133957 W2: 0,346789568662643 B: 0,308544129133224
W1: 0,283797711133957 W2: 0,346789568662643 B: 0,308544129133224
W1: -0,716202288866043 W2: -0,653210431337357 B: -0,691455870866776
TOTAL ERROR: 1
W1: -0,716202288866043 W2: -0,653210431337357 B: 0,308544129133224
W1: 0,283797711133957 W2: -0,653210431337357 B: 1,30854412913322
W1: 0,283797711133957 W2: -0,653210431337357 B: 1,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 0,308544129133224
TOTAL ERROR: 3
W1: -0,716202288866043 W2: -1,65321043133736 B: 0,308544129133224
W1: 0,283797711133957 W2: -1,65321043133736 B: 1,30854412913322
W1: 0,283797711133957 W2: -0,653210431337357 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 1,30854412913322
TOTAL ERROR: 3
W1: -0,716202288866043 W2: -1,65321043133736 B: 1,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 1,30854412913322
W1: -0,716202288866043 W2: -0,653210431337357 B: 2,30854412913322
W1: -1,71620228886604 W2: -1,65321043133736 B: 1,30854412913322
TOTAL ERROR: 2
W1: -1,71620228886604 W2: -1,65321043133736 B: 1,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
TOTAL ERROR: 1
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
TOTAL ERROR: 0
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
TOTAL ERROR: 0
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
W1: -0,716202288866043 W2: -1,65321043133736 B: 2,30854412913322
TOTAL ERROR: 0
Test 0 0: 1
Test 0 1: 1
Test 1 0: 1
Test 1 1: 0

```

#### XOR

| In 1 | In 2 | Out | 
| --- | --- | --- |
| 0 | 0 | 0 |
| 1 | 0 | 1 |
| 0 | 1 | 1 |
| 1 | 1 | 0 |

- В результате работы перцептрон выдаёт результаты с ошибками на каждой эпохе, в отличии от остальных логических операций.

```

W1: 0,473761528730392 W2: 0,500163078308105 B: -0,889534711837769
W1: 1,47376152873039 W2: 0,500163078308105 B: 0,110465288162231
W1: 1,47376152873039 W2: 0,500163078308105 B: 0,110465288162231
W1: 0,473761528730392 W2: -0,499836921691895 B: -0,889534711837769
TOTAL ERROR: 2
W1: 0,473761528730392 W2: -0,499836921691895 B: -0,889534711837769
W1: 1,47376152873039 W2: -0,499836921691895 B: 0,110465288162231
W1: 1,47376152873039 W2: 0,500163078308105 B: 1,11046528816223
W1: 0,473761528730392 W2: -0,499836921691895 B: 0,110465288162231
TOTAL ERROR: 3
W1: 0,473761528730392 W2: -0,499836921691895 B: -0,889534711837769
W1: 1,47376152873039 W2: -0,499836921691895 B: 0,110465288162231
W1: 1,47376152873039 W2: 0,500163078308105 B: 1,11046528816223
W1: 0,473761528730392 W2: -0,499836921691895 B: 0,110465288162231
TOTAL ERROR: 4
W1: 0,473761528730392 W2: -0,499836921691895 B: -0,889534711837769
W1: 1,47376152873039 W2: -0,499836921691895 B: 0,110465288162231
W1: 1,47376152873039 W2: 0,500163078308105 B: 1,11046528816223
W1: 0,473761528730392 W2: -0,499836921691895 B: 0,110465288162231
TOTAL ERROR: 4
W1: 0,473761528730392 W2: -0,499836921691895 B: -0,889534711837769
W1: 1,47376152873039 W2: -0,499836921691895 B: 0,110465288162231
W1: 1,47376152873039 W2: 0,500163078308105 B: 1,11046528816223
W1: 0,473761528730392 W2: -0,499836921691895 B: 0,110465288162231
TOTAL ERROR: 4
W1: 0,473761528730392 W2: -0,499836921691895 B: -0,889534711837769
W1: 1,47376152873039 W2: -0,499836921691895 B: 0,110465288162231
W1: 1,47376152873039 W2: 0,500163078308105 B: 1,11046528816223
W1: 0,473761528730392 W2: -0,499836921691895 B: 0,110465288162231
TOTAL ERROR: 4
W1: 0,473761528730392 W2: -0,499836921691895 B: -0,889534711837769
W1: 1,47376152873039 W2: -0,499836921691895 B: 0,110465288162231
W1: 1,47376152873039 W2: 0,500163078308105 B: 1,11046528816223
W1: 0,473761528730392 W2: -0,499836921691895 B: 0,110465288162231
TOTAL ERROR: 4
W1: 0,473761528730392 W2: -0,499836921691895 B: -0,889534711837769
W1: 1,47376152873039 W2: -0,499836921691895 B: 0,110465288162231
W1: 1,47376152873039 W2: 0,500163078308105 B: 1,11046528816223
W1: 0,473761528730392 W2: -0,499836921691895 B: 0,110465288162231
TOTAL ERROR: 4
Test 0 0: 1
Test 0 1: 0
Test 1 0: 1
Test 1 1: 1

```

## Задание 2
### Построить графики зависимости количества эпох от ошибки  обучения. Указать от чего зависит необходимое количество эпох обучения.

- Необходимое количество эпох обучения завист от сложности операции. По этой причине для AND или NAND потребуется меньше эпох, в отличии от операции XOR, которая является нелинейной. Для того чтобы перцептрон выдавал результаты этой операции без ошибок, нужно значительно больше эпох для обучения.

- см. [таблицу](https://docs.google.com/spreadsheets/d/1FEOONr9e6uaw2WJUgXUUNrZVaGC41jYBgP-UegZsYpQ/edit?usp=sharing).

## Задание 3
### Построить визуальную модель работы перцептрона на сцене Unity.

![screenshot](https://i.imgur.com/MmkrMvx.png)

- Пользователь может нажимать на кружки, которые при нажатии меняют цвет на чёрный, либо на белый, тем самым настраивая перцептрон и получая результат тестов в кружках снизу.

- см. [каталог](https://github.com/LeonKote/DA-in-GameDev-lab4/tree/master/UnityDataScience) с проектом.

## Выводы

В процессе работы я научился работать с перцептроном. Я узнал, как в проекте Unity реализовать перцептрон, который умеет производить вычисления OR, AND, NAND, XOR, как определить их корректность, как строить графики зависимости количества эпох от ошибки обучения, от чего зависит необходимое количество эпох обучения, а также как построить визуальную модель работы перцептрона на сцене Unity.

| Plugin | README |
| ------ | ------ |
| Dropbox | [plugins/dropbox/README.md][PlDb] |
| GitHub | [plugins/github/README.md][PlGh] |
| Google Drive | [plugins/googledrive/README.md][PlGd] |
| OneDrive | [plugins/onedrive/README.md][PlOd] |
| Medium | [plugins/medium/README.md][PlMe] |
| Google Analytics | [plugins/googleanalytics/README.md][PlGa] |

## Powered by

**BigDigital Team: Denisov | Fadeev | Panov**
