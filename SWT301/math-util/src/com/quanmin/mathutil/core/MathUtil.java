/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.quanmin.mathutil.core;

/**
 *
 * @author Fpt
 */
public class MathUtil {
    //trong class này cung cấp cho ai đó nhiều hàm
    //clone class Math của JDK
    //hàm thư viện xài chung cho ai đó, mà ko cần lưu lại các trạng thái/giá trị
    // chọn thiết kế static
    
    // hàm tính giai thừa!!!
    //n! = 1.2.3.4.5....n
    //ko co giai thừa âm
    //0! = 1! = 1 quy ước 
    //giai thừa hàm đồ thị đóc đứng, tăng nhanh về giá trị 
    //20 giai thừa là 18 con sô không, vừa kịp đủ kiểu long của Java
    //21 giai thừa tràn kiểu long 
    //bài này quy ước tính n! trong khoảng từ 0 -> 20
    
    public static long getFactorial(int n){
        if(n < 0 || n > 20)
            throw new IllegalArgumentException("Invalid agrument. N must be between 0...20");     
        if(n == 0 || n == 1)
            return 1; // kết htucs cuộc chơi sớm nếu nhận giá trị đặc biệt 
        long product = 1; // tích nhân dồn, thuật toán heo đất, ốc bu dồn thịt
        for (int i = 2; i <= n; i++) 
            product *= i;
        return product;
    }
}
