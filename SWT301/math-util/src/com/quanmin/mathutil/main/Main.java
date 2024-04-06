/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.quanmin.mathutil.main;

import com.quanmin.mathutil.core.MathUtil;

/**
 *
 * @author Fpt
 */
public class Main {
    public static void main(String[] args) {
        // thử nghiệm hàm tính giai thừa coi chạy đúng như thiết kế hay không 
        // ta phải đưa ra các tình huống sử dụng hàm trong thực tế 
        // ví dụ đưa vào âm 5, 0, 20 , 21 coi tính ra mấy 
        // TEST CASE: Một tình huống hàm/app/màn hình/tính năng được đưa vào sử dụng
        // giả lập hành vi xài của ai đó!!!
        
        //TEST CASE: Là 1 tình huống sử dụng app, xài app hay là xài hàm mà nó bao gồm 
        //INPUT: DATA đàu vào cụ thể nào đó
        //OUTPUT: đầu ra ứng với xử lí của hàm/chức năng của APP, dĩ nhiên dùng đầu vào để xử lí 
        //Kì Vọng: mong hàm sẽ trả về Value nào đó ứng với input ở trên  
        //So sánh để xem kết quả có như kì vọng hay không 
        
        long expected = 120; //tao kì vọng hàm ói về 120 nếu tính 5!
        int n = 5;           //input 
        long actual = MathUtil.getFactorial(n);
        System.out.println("5! = " + expected + " expected");
        System.out.println("5! = " + actual + " actual");
    }
}
