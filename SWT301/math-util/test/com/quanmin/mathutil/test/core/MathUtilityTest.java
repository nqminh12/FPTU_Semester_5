/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package com.quanmin.mathutil.test.core;

import com.quanmin.mathutil.core.MathUtil;
import org.junit.Assert;
import org.junit.Test;



/**
 *
 * @author Fpt
 */
public class MathUtilityTest {
    //Đây là class sẽ sử dụng các hàm của thư viện/framework JUnit
    //để kiểm thử/kiểm tra code chính - hàm tínhGiaiThừa() bên
    //class core.MathUtil
    //viết code để test code chính bên kia!!!
    //có nhiều quy tắc đặt tên hàm kiểm thử
    //nhưng thường sẽ là nói lên mục đích của các case/tình huống kiểm thử
    //tình huống xài hàm theo kiểu thành công và thất bại!!!
    
    
    //hàm dưới đây là tình huống test hàm chạy thành công, trả về ngon
    //ta sẽ xài hàm kiểu well - đưa 5!, 6!, hok chơi đưa -5!, 30!
    
    //@Test JUnit sẽ phối hợp với JVM để chạy hàm này 
    //@Test phía hậu trường chính là public static void main()
    //Có nhiều @Test ứng với nhiều case khác nhau để kiểm thử hàm tính giai thừa
    @Test
    public void testGetFactorialGivenRightArgumentReturnsWell(){
        int n = 0;  //test thử tình huống tử tế đầu vào, máy phải chạy đúng
        long expected = 1;  //hy vọng 0! = 1
        
        //long actual = ;// gọi hàm cần test bên core/app chính/code chính
        long actual = MathUtil.getFactorial(n);
        
        //so sánh expected vs. actual dùng xanh xanh đỏ đỏ, framework
        Assert.assertEquals(expected, actual);
        
        
        //gộp thêm vài case thành công/đưa đầu vào ngon!! hàm phải tính ngon
        Assert.assertEquals(1, MathUtil.getFactorial(1));//tui mún 1! == 1
        Assert.assertEquals(2, MathUtil.getFactorial(2));//tui mún 2! == 2
        Assert.assertEquals(6, MathUtil.getFactorial(3));//tui mún 3! == 6
        Assert.assertEquals(24, MathUtil.getFactorial(4));//tui mún 4! == 24
        Assert.assertEquals(120, MathUtil.getFactorial(5));//tui mún 5! == 120
        Assert.assertEquals(720, MathUtil.getFactorial(6));//tui mún 6! == 720
        
        
        
        
    }
    //hàm giúp so sánh hai giá trị nào đó có giống nhau hay không 
        //nếu giống nhau -> thảy màu xanh đèn đường - đường thông, code ngon
        //                  ít nhất cho case đang test
        //nếu không giống nhau -> thảy màu đỏ đèn đường 
        //                        hàm ý expected và actual ko giống nhau
    
    
}
