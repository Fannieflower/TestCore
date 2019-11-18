using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class SortingInfoResult {
		
		///<summary>
		/// 批次号
		///</summary>
		
		private string batchno_;
		
		///<summary>
		/// 请求方请求条数
		///</summary>
		
		private int? totalCount_;
		
		///<summary>
		/// 成功条数
		///</summary>
		
		private int? successCount_;
		
		///<summary>
		/// 失败条数 正常情况为0
		///</summary>
		
		private int? failCount_;
		
		///<summary>
		/// 返回明细
		///</summary>
		
		private List<com.vip.top.carrier.bizservice.SortingInfoResponseItem> sortingInfoResponseItems_;
		
		public string GetBatchno(){
			return this.batchno_;
		}
		
		public void SetBatchno(string value){
			this.batchno_ = value;
		}
		public int? GetTotalCount(){
			return this.totalCount_;
		}
		
		public void SetTotalCount(int? value){
			this.totalCount_ = value;
		}
		public int? GetSuccessCount(){
			return this.successCount_;
		}
		
		public void SetSuccessCount(int? value){
			this.successCount_ = value;
		}
		public int? GetFailCount(){
			return this.failCount_;
		}
		
		public void SetFailCount(int? value){
			this.failCount_ = value;
		}
		public List<com.vip.top.carrier.bizservice.SortingInfoResponseItem> GetSortingInfoResponseItems(){
			return this.sortingInfoResponseItems_;
		}
		
		public void SetSortingInfoResponseItems(List<com.vip.top.carrier.bizservice.SortingInfoResponseItem> value){
			this.sortingInfoResponseItems_ = value;
		}
		
	}
	
}