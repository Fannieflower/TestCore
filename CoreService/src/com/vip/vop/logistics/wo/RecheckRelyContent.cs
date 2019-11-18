using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class RecheckRelyContent {
		
		///<summary>
		/// 工单号
		/// @sampleValue work_order_no DH201812274412200
		///</summary>
		
		private string work_order_no_;
		
		///<summary>
		/// 回复内容
		/// @sampleValue content 
		///</summary>
		
		private string content_;
		
		public string GetWork_order_no(){
			return this.work_order_no_;
		}
		
		public void SetWork_order_no(string value){
			this.work_order_no_ = value;
		}
		public string GetContent(){
			return this.content_;
		}
		
		public void SetContent(string value){
			this.content_ = value;
		}
		
	}
	
}