using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractViewSaveParams {
		
		///<summary>
		/// 主信息表
		///</summary>
		
		private long? mainId_;
		
		///<summary>
		/// 合同内容，用于生成pdf
		///</summary>
		
		private string content_;
		
		public long? GetMainId(){
			return this.mainId_;
		}
		
		public void SetMainId(long? value){
			this.mainId_ = value;
		}
		public string GetContent(){
			return this.content_;
		}
		
		public void SetContent(string value){
			this.content_ = value;
		}
		
	}
	
}