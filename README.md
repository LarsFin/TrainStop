﻿# TrainStop ~ C# Project

Simple project to practice C# development in .NET Core. Project will practice TDD, using MsTest.


User Stories;

Trains have names [ ]
```
As a Train Manager,
So I can easily refer to my train,
Trains should have names.
```

Stations have names [ ]
```
As a Train Manager,
So I can easily refer to my destinations,
Stations should have names.
```

Trains have a state of motion [ ]
```
As a Train Manager,
So I know when a train has left,
Trains should have a state of motion.
```

Stations should be able to hold trains [ ]
```
As a Train Manager,
So I can stop my train at a station,
Stations should be able to hold a train.
```

Stations should be able to receive trains [ ]
```
As a Train Manager,
So I can enter a station by train,
Stations should have an effective method by which to receive trains.
```

Trains can depart from Stations [ ]
```
As a Train Manager,
So I can leave a station by train,
Stations should have an effective method by which to release trains.
```

Stations can store a maximum number of trains [ ]
```
As a Station Manager,
So I avoid trains crashing,
Stations should not receive a train when at capacity.
```

Stations can be under maintenance [ ]
```
As a Station Manager,
So work can occurr on a station with no disruption,
Stations should not receive a train when under maintenance.
```