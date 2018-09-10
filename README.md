# SP Generator From Navicat

## What is this?

Just another "bored" project. Main function is generate INSERT and UPDATE query (basically, for using stored procedure) from Navicat DDL Object Information. You may generate query just in single click instead typing a lot of code (its be your savior if you have for example >100 column table).

## Its working, but...

If your table have column special property (i dunno what is called)... for example in your Navicat DDL Object information:
```
CREATE TABLE `ms_lang` (
  `langCode` varchar(3) NOT NULL,
  `langName` varchar(30) NOT NULL,
  `inputTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `imputUN` varchar(50) NOT NULL,
  `modifTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifUN` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`langCode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
```
Before paste code to apps, you must delete "PRIMARY KEY" row or make sure you have column detail only. Below code is ready to paste in apps.

```
CREATE TABLE `ms_lang` (
  `langCode` varchar(3) NOT NULL,
  `langName` varchar(30) NOT NULL,
  `inputTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `imputUN` varchar(50) NOT NULL,
  `modifTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modifUN` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
```

## Screenshot
![1st screenshot](https://s15.postimg.cc/5fr3lm14r/Screenshot_39.jpg)
