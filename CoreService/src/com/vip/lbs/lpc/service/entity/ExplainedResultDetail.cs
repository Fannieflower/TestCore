using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.lbs.lpc.service.entity{
	
	
	
	
	
	public class ExplainedResultDetail {
		
		///<summary>
		/// 解析条码的结果列表
		///</summary>
		
		private List<string> explainedBarcodes_;
		
		///<summary>
		/// 状态，true：成功；false：失败
		///</summary>
		
		private bool? status_;
		
		public List<string> GetExplainedBarcodes(){
			return this.explainedBarcodes_;
		}
		
		public void SetExplainedBarcodes(List<string> value){
			this.explainedBarcodes_ = value;
		}
		public bool? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(bool? value){
			this.status_ = value;
		}
		
	}
	
}