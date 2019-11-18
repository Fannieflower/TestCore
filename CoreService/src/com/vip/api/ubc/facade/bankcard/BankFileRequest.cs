using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.ubc.facade.bankcard{
	
	
	
	
	
	public class BankFileRequest {
		
		///<summary>
		/// 银行名,广发:CGB,建行:CCB,招行:CMB,浦发:SPDB,中行:BOC
		///</summary>
		
		private string bankName_;
		
		///<summary>
		/// base64的文件流字符串
		///</summary>
		
		private string fileStreamStr_;
		
		///<summary>
		/// 文件中数据的条数,即包含多少条数据,以供唯品会侧检测数据是否全部成功导入
		///</summary>
		
		private int? fileDataNum_;
		
		public string GetBankName(){
			return this.bankName_;
		}
		
		public void SetBankName(string value){
			this.bankName_ = value;
		}
		public string GetFileStreamStr(){
			return this.fileStreamStr_;
		}
		
		public void SetFileStreamStr(string value){
			this.fileStreamStr_ = value;
		}
		public int? GetFileDataNum(){
			return this.fileDataNum_;
		}
		
		public void SetFileDataNum(int? value){
			this.fileDataNum_ = value;
		}
		
	}
	
}