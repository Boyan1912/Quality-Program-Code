﻿# Шаблони за създаване (Creational Patterns)

## Singleton

Шаблонът "Сингълтън" се използва тогава, когато даден обект се очаква да има само една единствена инстанция, 
която да е достъпна в цялото приложение. Поради тези си характеристики "Сингълтън" прилича на статичен клас
или глобална променлива. Разликите между "Сингълтън" и "static class" са следните:
* Статичният клас е вече заделена памет в компютъра без значение дали се използва или не. "Сингълтън" се създава 
точно преди да се използва и след това се зачиства от garbage collector (lazy instantiation).
* Статичният клас не забранява да се правят повече от една инстанция
* При "Сингълтън" имаме възможност сами да определяме как да се създава инстанцията на класа

"Сингълтън" обикновено се използва при създаването на Logger клас или при конфигурирането на други класове, като
съхранява в себе си вече направените настройки, логове. Така не се налага да се извикват другите класове наново
всеки път, когато потрябват. Може да се използва и в комбинация с "Abstract Factory" или "Factory Method", гарантирайки
създаването на уникален (единствен) обект със съответните характеристики (банкова сметка, ЕГН и др.). 

В съвременото програмиране шаблонът "Сингълтън" се избягва поради сериозните си недостатъци като създаването на силна обвързаност
между класовете в приложението (tight coupling), проблеми при многонишково програмиране, проблемно тестване и др.