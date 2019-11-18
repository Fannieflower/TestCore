using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.jingdong{
	
	
	
	
	
	public class SkuCommission {
		
		///<summary>
		/// 商品编号sku_id
		///</summary>
		
		private string sku_id_;
		
		///<summary>
		/// 扣点，精确到4位小数
		///</summary>
		
		private double? commission_;
		
		///<summary>
		/// 是否成功获取到扣点:false-失败、true-成功
		///</summary>
		
		private bool? is_success_;
		
		///<summary>
		/// 获取扣点响应信息
		///</summary>
		
		private string msg_;
		
		public string GetSku_id(){
			return this.sku_id_;
		}
		
		public void SetSku_id(string value){
			this.sku_id_ = value;
		}
		public double? GetCommission(){
			return this.commission_;
		}
		
		public void SetCommission(double? value){
			this.commission_ = value;
		}
		public bool? GetIs_success(){
			return this.is_success_;
		}
		
		public void SetIs_success(bool? value){
			this.is_success_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		
	}
	
}