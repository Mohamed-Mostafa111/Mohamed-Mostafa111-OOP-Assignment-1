Task 3.2
constructor with around 20 parameters creates several problems:

- **Poor readability:** It becomes difficult to understand what each argument represents.
- **Wrong parameter order:** Many parameters have the same type so user may make mistake at the order of parameters
- **Hard to maintain:** Adding a new property requires remembering the arrangement of parameters
- **Difficult to use:** The caller has to remember many parameters at the same time.

Task 3.3:
the composed builder design pattern is better because each better has asingle responsebility as Invoice Examble we have
constructor with around 20 parameters soma variables has the same type so we can groubing block of variables which
belongs to spacific part of this object as AddressBuilder handles only address construction ,OrderBuilder handels only
order and payment information only and so on.
