using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractAttachmentParams {
		
		///<summary>
		/// 活动确认函id
		///</summary>
		
		private long? mainId_;
		
		///<summary>
		/// 附件名称
		///</summary>
		
		private string title_;
		
		///<summary>
		/// 附件url
		///</summary>
		
		private string url_;
		
		///<summary>
		/// 创建人
		///</summary>
		
		private string createBy_;
		
		public long? GetMainId(){
			return this.mainId_;
		}
		
		public void SetMainId(long? value){
			this.mainId_ = value;
		}
		public string GetTitle(){
			return this.title_;
		}
		
		public void SetTitle(string value){
			this.title_ = value;
		}
		public string GetUrl(){
			return this.url_;
		}
		
		public void SetUrl(string value){
			this.url_ = value;
		}
		public string GetCreateBy(){
			return this.createBy_;
		}
		
		public void SetCreateBy(string value){
			this.createBy_ = value;
		}
		
	}
	
}