# Git-and-GitHub-Teamwork
SoftUni Git and GitHub - Teamwork Exercises

# Problem 01 -> Debit Card Number #

Write a program, which receives **4** **integers** on the console and **prints them** in **4-digit debit card format**. See the examples below for the appropriate formatting.

**Examples**
<table>
    <tr>
        <td>Input</td>
        <td>Output</td>
    </tr>
    <tr>
        <td>
            12     <br>
            433    <br>
            1      <br>
            5331   <br>
        </td>
        <td>0012 0433 0001 5331</td>
    </tr>
    <tr>
        <td>
            9182    <br>
            4221    <br>
            12      <br>
            3       <br>
        </td>
        <td>9182 4221 0012 0003</td>
    </tr>
    <tr>
        <td>
            812     <br>
            321     <br>
            123     <br>
            22      <br>
        </td>
        <td>0812 0321 0123 0022</td>
    </tr>
</table>


# Problem 02 -> Rectangle Area #



# Problem 03 -> Miles to Kilometers #
Write a program, which **converts** **miles** to **kilometers**. **Format** the output to the **2** **nd** **decimal place**.

Note: **1 mile == 1.60934 kilometers**

**Examples**

| Input | Output |   | Input | Output |   | Input   | Output |
|:-----:|--------|---|-------|--------|---|---------|--------|
| 60    | 96.56  |   | 1     | 1.61   |   | 52.1113 | 83.86  |



# Problem 04 -> Beverage Labels #

Write a program, which calculates the energy and sugar content for a given product.
	The input will be:		
- name of the food product	
- volume of the packed product	
- energy content per 100ml	
- sugar content per 100ml

	The print on the console has to be in the following format:
- volume of the packed product, suffixed by "ml" name of the food product
- energy content, suffixed by "kcal", sugar content, suffixed by "g"

**Examples**

<table>
    <tr>
        <td>Input</td>
        <td>Output</td>
    </tr>
    <tr>
        <td>
            Nuka-Cola     <br>
            220   		  <br>
            300    		  <br>
            70     		  <br>
			 </td>
        <td>
			220ml Nuka-Cola:		<br>
			660kcal, 154g sugars	<br>
		</td>
    </tr>    
</table>

 

# Problem 05 -> Character Stats #

Write a program, which **displays information** about a video game character. You will receive their **name**, **current health**, **maximum health**, **current energy** and **maximum energy** on separate lines. The **current** values will **always** be valid (**equal or lower** than their respective **max** values). Print them in the format as per the examples.

**Examples**
<table>
    <tr>
        <td>Input</td>
        <td>Output</td>
    </tr>
    <tr>
        <td>
            Mayro   <br>
            5       <br>
            10      <br>
            9       <br>
            10      <br>
        </td>
        <td>Name: Mayro <br>
            Health: ||||||.....|<br>
            Energy: ||||||||||.|<br>
        </td>
    </tr>
	<tr>
        <td>
            Bauser   <br>
            10       <br>
            10      <br>
            10       <br>
            10      <br>
        </td>
        <td>Name: Bauser <br>
            Health: ||||||||||||<br>
            Energy: ||||||||||||<br>
        </td>
    </tr>
	
<tr>
        <td>
            Loogi   <br>
            8       <br>
            20      <br>
            2       <br>
            14      <br>
        </td>
        <td>Name: Loogi <br>
            Health: |||||||||............|<br>
            Energy: |||............|<br>
        </td>
    </tr>
	

	
<tr>
        <td>
            Toad   <br>
            0       <br>
            5      <br>
            0       <br>
            10      <br>
        </td>
        <td>Name: Toad <br>
            Health: |.....|<br>
            Energy: |..........|<br>
        </td>
    </tr>
	
</table>

**Hints**

- You can print a character **multiple** times, using **new string(character, count)**.
