# Design-Patterns-Singleton

### The Singleton design pattern is used to ensure that an application never contains more than a single instance of a given type.
### There can be various reasons why we would want this behaviour.
### In our current example, we are modelling a grading system, where teachers can upload the results of the exams students are taking in a school. The teachers can also ask for the list of exams taken. To support these functions, the application has two console screens: one for uploading an exam, and another for showing the exams.
### Both screens must have a reference to same IExamRepository instance according to the Singleton design pattern. 