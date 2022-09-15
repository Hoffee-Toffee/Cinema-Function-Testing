
# Cinema Ticket App Testing

## AdultBefore5

This function should return a ticket price of $15.00 for an adult before 5pm.
Won't work on Tuesdays because Tuesdays have a separate discount.

| Variable | Acceptable | Unacceptable |
|----------|------------|--------------|
| Quantity | > 0        | <= 0         |
| Person   | Adult      | Child, Senior, Student, Family |
| Day      | Monday, Wednesday, Thursday, Friday, Saturday, Sunday | Tuesday |
| Time     | < 0500     | >= 0500 |

| Quantity | Person | Day | Time | Expected Result | Actual Result | Pass/Fail |
|----------|--------|-----|------|-----------------| --------------|-----------|
| 0        | Adult  | Monday | 0400 | -$1.00 | -$1.00 | Pass |
| 1        | Adult  | Monday | 0400 | $15.00 | $15.00 | Pass |
| 2        | Adult  | Monday | 0400 | $30.00 | $30.00 | Pass |
| 1        | Child  | Monday | 0400 | -$1.00 | -$1.00 | Pass |
| 1        | Adult  | Tuesday | 0400 | -$1.00 | -$1.00 | Pass |
| 1        | Adult  | Monday | 0600 | -$1.00 | -$1.00 | Pass |

## AdultAfter5

This function should return a ticket price of $18.00 for an adult after 5pm.
Won't work on Tuesdays because Tuesdays have a separate discount.

| Variable | Acceptable | Unacceptable |
|----------|------------|--------------|
| Quantity | > 0        | <= 0         |
| Person   | Adult      | Child, Senior, Student, Family |
| Day      | Monday, Wednesday, Thursday, Friday, Saturday, Sunday | Tuesday |
| Time     | >= 0500     | < 0500 |

| Quantity | Person | Day | Time | Expected Result | Actual Result | Pass/Fail |
|----------|--------|-----|------|-----------------| --------------|-----------|
| 0        | Adult  | Monday | 0600 | -$1.00 | -$1.00 | Pass |
| 1        | Adult  | Monday | 0600 | $18.00 | $18.00 | Pass |
| 2        | Adult  | Monday | 0600 | $36.00 | $36.00 | Pass |
| 1        | Child  | Monday | 0600 | -$1.00 | -$1.00 | Pass |
| 1        | Adult  | Tuesday | 0600 | -$1.00 | -$1.00 | Pass |
| 1        | Adult  | Monday | 0400 | -$1.00 | -$1.00 | Pass |

## AdultTuesday

This function should return a ticket price of $14.00 for an adult on Tuesday.

| Variable | Acceptable | Unacceptable |
|----------|------------|--------------|
| Quantity | > 0        | <= 0         |
| Person   | Adult      | Child, Senior, Student, Family |
| Day      | Tuesday    | Monday, Wednesday, Thursday, Friday, Saturday, Sunday |

| Quantity | Person | Day | Expected Result | Actual Result | Pass/Fail |
|----------|--------|-----|-----------------| --------------|-----------|
| 0        | Adult  | Tuesday | -$1.00 | -$1.00 | Pass |
| 1        | Adult  | Tuesday | $14.00 | $14.00 | Pass |
| 2        | Adult  | Tuesday | $28.00 | $28.00 | Pass |
| 1        | Child  | Tuesday | -$1.00 | -$1.00 | Pass |
| 1        | Adult  | Monday | -$1.00 | -$1.00 | Pass |

## ChildUnder16

This function should return a ticket price of $13.00 for a child under 16.

| Variable | Acceptable | Unacceptable |
|----------|------------|--------------|
| Quantity | > 0        | <= 0         |
| Person   | Child      | Adult, Senior, Student, Family |

| Quantity | Person | Expected Result | Actual Result | Pass/Fail |
|----------|--------|-----------------| --------------|-----------|
| 0        | Child  | -$1.00 | -$1.00 | Pass |
| 1        | Child  | $13.00 | $13.00 | Pass |
| 2        | Child  | $26.00 | $26.00 | Pass |
| 1        | Adult  | -$1.00 | -$1.00 | Pass |

## Senior

This function should return a ticket price of $13.00 for a senior.

| Variable | Acceptable | Unacceptable |
|----------|------------|--------------|
| Quantity | > 0        | <= 0         |
| Person   | Senior     | Adult, Child, Student, Family |

| Quantity | Person | Expected Result | Actual Result | Pass/Fail |
|----------|--------|-----------------| --------------|-----------|
| 0        | Senior | -$1.00 | -$1.00 | Pass |
| 1        | Senior | $12.00 | $12.50 | Fail |
| 2        | Senior | $24.00 | $25.00 | Fail |
| 1        | Adult  | -$1.00 | -$1.00 | Pass |

## Student

This function should return a ticket price of $15.00 for a student.

| Variable | Acceptable | Unacceptable |
|----------|------------|--------------|
| Quantity | > 0        | <= 0         |
| Person   | Student    | Adult, Child, Senior, Family |

| Quantity | Person | Expected Result | Actual Result | Pass/Fail |
|----------|--------|-----------------| --------------|-----------|
| 0        | Student | -$1.00 | -$1.00 | Pass |
| 1        | Student | $15.00 | $15.00 | Pass |
| 2        | Student | $30.00 | $30.00 | Pass |
| 1        | Adult  | -$1.00 | -$1.00 | Pass |

## FamilyPass

This function should return a ticket price of $49.00 for a family pass.
Families are defined as 2 Adults and 2 Children or 1 Adult and 3 Children

| Variable | Acceptable | Unacceptable |
|----------|------------|--------------|
| Adults   | 1 (if 3 children), 2 (if 2 children) | <= 0, > 2 |
| Children | 2 (if 2 adults), 3 (if 1 adult) | <= 1, > 3 |

| Adults | Children | Expected Result | Actual Result | Pass/Fail |
| ------ | -------- | --------------- | ------------- | --------- |
| 2      | 2        | $49.00 | $49.00 | Pass |
| 1      | 3        | $49.00 | $49.00 | Pass |
| 3      | 2        | -$1.00 | -$1.00 | Pass |
| 2      | 3        | -$1.00 | -$1.00 | Pass |
| 1      | 1        | -$1.00 | -$1.00 | Pass |
| 0      | 0        | -$1.00 | -$1.00 | Pass |

## ChickFlickThursday

This function should return a ticket price of $12.50 for an adult on Thursday.

| Variable | Acceptable | Unacceptable |
|----------|------------|--------------|
| Quantity | > 0        | <= 0         |
| Person   | Adult      | Child, Senior, Student, Family |
| Day      | Thursday   | Monday, Tuesday, Wednesday, Friday, Saturday, Sunday |

| Quantity | Person | Day | Expected Result | Actual Result | Pass/Fail |
|----------|--------|-----|-----------------| --------------|-----------|
| 0        | Adult  | Thursday | -$1.00 | -$1.00 | Pass |
| 1        | Adult  | Thursday | $12.50 | $12.50 | Pass |
| 2        | Adult  | Thursday | $25.00 | $25.00 | Pass |
| 1        | Child  | Thursday | -$1.00 | -$1.00 | Pass |
| 1        | Adult  | Monday | -$1.00 | -$1.00 | Pass |

## KidsCareers

This function should return a ticket price of $12.00 for a child on the first Wednesday of the month.

| Variable | Acceptable | Unacceptable |
|----------|------------|--------------|
| Quantity | > 0        | <= 0         |
| Person   | Child      | Adult, Senior, Student, Family |
| Day      | Wednesday  | Monday, Tuesday, Thursday, Friday, Saturday, Sunday |
| Holiday  | True | False |

| Quantity | Person | Day | Holiday | Expected Result | Actual Result | Pass/Fail |
|----------|--------|-----|---------|-----------------| --------------|-----------|
| 0        | Child  | Wednesday | True | -$1.00 | -$1.00 | Pass |
| 1        | Child  | Wednesday | True | $12.00 | -$1.00 | Fail |
| 2        | Child  | Wednesday | True | $24.00 | -$1.00 | Fail |
| 1        | Adult  | Wednesday | True | -$1.00 | -$1.00 | Pass |
| 1        | Child  | Thursday | True | -$1.00 | -$1.00 | Pass |
| 1        | Child  | Wednesday | False | -$1.00 | -$1.00 | Pass |

