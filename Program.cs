Console.WriteLine("fyck");

bool result = IMember.IsValidContactNumber("0404925759");
Console.WriteLine("IsValidContactNumber(0404925759) -> " + result.ToString());

bool result2 = IMember.IsValidContactNumber("4404925759");
Console.WriteLine("IsValidContactNumber(4404925759) -> " + result2.ToString());

bool result3 = IMember.IsValidContactNumber("0111");
Console.WriteLine("IsValidContactNumber(0111) -> " + result3.ToString());

bool result4 = IMember.IsValidContactNumber("0000000000");
Console.WriteLine("IsValidContactNumber(0000000000) -> " + result4.ToString());

bool result5 = IMember.IsValidContactNumber("000000000000");
Console.WriteLine("IsValidContactNumber(000000000000) -> " + result5.ToString());

bool result6 = IMember.IsValidContactNumber("aaaa");
Console.WriteLine("IsValidContactNumber(aaaa) -> " + result6.ToString());

bool result7 = IMember.IsValidContactNumber("0abcdefghi");
Console.WriteLine("IsValidContactNumber(0abcdefghi) -> " + result7.ToString());

bool pin1 = IMember.IsValidPin("0000");
Console.WriteLine("IsValidPin(0000) -> " + pin1.ToString());

bool pin2 = IMember.IsValidPin("00000");
Console.WriteLine("IsValidPin(00000) -> " + pin2.ToString());

bool pin3 = IMember.IsValidPin("000000");
Console.WriteLine("IsValidPin(000000) -> " + pin3.ToString());

bool pin4 = IMember.IsValidPin("-10000");
Console.WriteLine("IsValidPin(-10000) -> " + pin4.ToString());

bool pin5 = IMember.IsValidPin("1234567");
Console.WriteLine("IsValidPin(1234567) -> " + pin5.ToString());

bool pin6 = IMember.IsValidPin("aaaaa");
Console.WriteLine("IsValidPin(aaaaa) -> " + pin6.ToString());

Console.Read();