using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.ubc.facade.bankcard{
	
	
	
	
	
	public class BankDataRequest {
		
		///<summary>
		/// 银行名,广发:CGB,建行:CCB,招行:CMB,浦发:SPDB,中行:BOC
		///</summary>
		
		private string bankName_;
		
		///<summary>
		/// 传输的数据内容,中行的为json格式字符串,并进行加密处理
		///</summary>
		
		private string dataStr_;
		
		///<summary>
		/// 数据内容中包含的数据条数,用于核对是否全部成功被唯品会解析,单次最大不超过50
		///</summary>
		
		private int? dataNum_;
		
		public string GetBankName(){
			return this.bankName_;
		}
		
		public void SetBankName(string value){
			this.bankName_ = value;
		}
		public string GetDataStr(){
			return this.dataStr_;
		}
		
		public void SetDataStr(string value){
			this.dataStr_ = value;
		}
		public int? GetDataNum(){
			return this.dataNum_;
		}
		
		public void SetDataNum(int? value){
			this.dataNum_ = value;
		}
		
	}
	
}