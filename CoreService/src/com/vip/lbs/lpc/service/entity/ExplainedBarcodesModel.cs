using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.lbs.lpc.service.entity{
	
	
	
	
	
	public class ExplainedBarcodesModel {
		
		///<summary>
		/// 序号
		///</summary>
		
		private string serialNo_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 期望商品条码
		///</summary>
		
		private string barCode_;
		
		///<summary>
		/// 待解析条码
		///</summary>
		
		private string toBeExplainedBarcode_;
		
		public string GetSerialNo(){
			return this.serialNo_;
		}
		
		public void SetSerialNo(string value){
			this.serialNo_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetBarCode(){
			return this.barCode_;
		}
		
		public void SetBarCode(string value){
			this.barCode_ = value;
		}
		public string GetToBeExplainedBarcode(){
			return this.toBeExplainedBarcode_;
		}
		
		public void SetToBeExplainedBarcode(string value){
			this.toBeExplainedBarcode_ = value;
		}
		
	}
	
}