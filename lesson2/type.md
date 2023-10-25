## Value Type
به داده نوعی Value Type گفته میشود که یک مقدار را در فضای حافظه ی خود ذخیره کند. و این به این معناست که متغیر هایی که از نوع این داده نوع تعریف میشوند به طور مستقیم دارای مقداری در خود هستند.

نکته : تمام Value Type ها از فضای نام `System.ValueType` مشتق میشوند که آن فضای نامی هم در فضای نام `System.Object` قرار دارد.
### همه ی داده هایی که در زیر آورده شده است از نوع value type هستند :
<table>
  <tr>
    <td>bool</td><td>byte</td><td>char</td><td>decimal</td><td>double</td>
  </tr>
  <tr>
    <td>sbyte</td><td>long</td><td>int</td><td>float</td><td>enum</td>
  </tr>
  <tr>
    <td>ushort</td><td>ulong</td><td>unit</td><td>sbyte</td><td>short</td>
  </tr>
</table>

## Reference Type
برخلاف Value Type ها ، Reference Type ها مقادیرشان را به صورت مستقیم در خود ذخیره نمی کنند. در عوض آنها آدرس مکانی از حافظه را که مقدار در آن قرار گرفته است، در خود ذخیره میکنند. به عبارت دیگر Reference Type ها شامل یک اشاره گر هستند که به مکانی دیگر از حافظه اشاره میکند که داده یا مقدار در آن ذخیره شده است.
![image](https://github.com/DeAref/backend-practice/assets/95649368/60850d99-1547-45bc-855f-56c9220273ee)
همانطور که در تصویر بالا مشاهده می کنید سیستم یک مکان تصادفی در حافظه (0x803200) را برای متغیر "S" انتخاب کرده است. مقداری که در متغیر "S" قرار میگیرد 0x600000 است که آدرس خانه ای از حافظه است که مقدار اصلی یعنی !!Hello Worlds در آن قرار گرفته است.
داده نوع های زیر همگی Reference Type هستند :

- String
تمام آرایه ، حتی اگر مقادیر آنها از نوع value type باشد
- Class
- Delegates


