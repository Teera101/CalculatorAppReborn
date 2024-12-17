# calculator
 # Calculator

by Teera Rewtawee,
653450288-5,
Computer and Infomation Science, KKU

# การรับและการแสดงผลข้อมูล

รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

## ปุ่มบวก

```
 private void button1_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            //convert string to double
            double iNum1 = Int32.Parse(inputNum1);
            double iNum2 = Int32.Parse(inputNum2);

            double iResult = iNum1 + iNum2;
            result.Text = iResult.ToString();

        }
```

### รับข้อมูล

ตัวอย่าง

```
 string inputNum1 = num1.Text;
 string inputNum2 = num2.Text;
```

### แปลงชนิดของข้อมูล

ตัวอย่าง

```
double iNum1 = Int32.Parse(inputNum1);
double iNum2 = Int32.Parse(inputNum2);
```

### คำนวนผลลัพท์

ตัวอย่าง

```
double iResult = iNum1 + iNum2;
```

### แสดงผล

ตัวอย่าง

```
result.Text = iResult.ToString();
```

## ปุ่มลบ
```
 private void button2_Click(object sender, EventArgs e)
        {
            
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            double iNum1 = Int32.Parse(inputNum1);
            double iNum2 = Int32.Parse(inputNum2);

            double iResult = iNum1 - iNum2;
            result.Text = iResult.ToString();
        }
```
## ปุ่มคูณ
```
 private void button3_Click(object sender, EventArgs e)
        {
            
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            double iNum1 = Int32.Parse(inputNum1);
            double iNum2 = Int32.Parse(inputNum2);

            double iResult = iNum1 * iNum2;
            result.Text = iResult.ToString();

        }
```
## ปุ่มหาร
```
 private void button4_Click(object sender, EventArgs e)
        {
            
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            double iNum1 = Int32.Parse(inputNum1);
            double iNum2 = Int32.Parse(inputNum2);

            double iResult = iNum1 / iNum2;
            result.Text = iResult.ToString();
        }
```
## ปุ่มลบข้อมูล
```
 private void button5_Click(object sender, EventArgs e)
        {
            //clear textbox result
            result.Text = "";
            num1.Text = "";
            num2.Text = "";
        }
```
