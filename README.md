# fgup-test-project
Тестовое задание для фгуп.

Нет бандлера. FgupAPI - должно быть nugget пакетом(сейчас подключен через reference). FgupTestWebApi - должен иметь доступ только в локальную сеть. FgupTestWebApp - должен иметь доступ к Api и в сеть.

TableDataService.CreateResponseAsync - если будет добавляться логика, необходимо будет разнести для простоты тестов, делал отталкиваясь от наименьшего использования бд, например нельзя значения посчитать на базе(например через триггеры).

У "бд" не делал никаких связей и тд. Данные взял отсюда "папка с примером набора данных (Excel) из 3-х ФО, по 2 субъекта в каждом, по 3 маршрута для каждого субъекта. JSON для этого набора данных лежит там же.".
