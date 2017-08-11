# _Word Counter_

#### _Finds the number of instances of a certain word in a string, August 11, 2017_

#### By _**Kim Schulze**_

## Description

_The user can input a string, designate a word to be counted and then return the number of times that word appears in the string._

## Setup/Installation Requirements

* _Use an up-to-date browser._

## Specifications
| Behavior | Input | Output | Reasoning |
| ---- | ---- | ---- | ---- |
| 1. Count more than one instance of a word in a sentence. | The cat that I like the most is Callie cat | 2 | Method must cycle all words until it finds all instances and comes to the end of the string. |
| 2. Count words despite upper or lower case. | Cat toys include cap nip | 2 | User may input the word with a capital letter or a mix of upper or lower case. |
| 3. Count instances of a word when surrounded by punctuation. | Callie cat is my favorite cat. | 2 | If words are determined by spaces, then punctuation would get in the way of this. |
| 4. Count instances of a word but neglect words that include the smaller word as part of a larger word. | My cat stayed home while I went to the cathedral. | 1 |  If we break the word down by character, the method will find "cat" in cathedral. |
| 5. Include words that are pluralized | Cats and dogs are my favorite | 1 | It seems like a pluralized word would be part of the count |


## Known Bugs

_There are no known bugs._

## Support and contact details

_With questions contact Kim Schulze at kimberlykayschulze@gmail.com._

## Technologies Used

_Used C#, .NET, MVC, and HTML_

### License

*All Rights Reserved.  Version 1.0*

Copyright (c) 2017 **_Kim Schulze_**
