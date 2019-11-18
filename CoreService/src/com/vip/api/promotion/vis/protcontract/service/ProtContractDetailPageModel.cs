using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractDetailPageModel {
		
		///<summary>
		/// 数据总数量
		///</summary>
		
		private int? totalCount_;
		
		///<summary>
		/// 当前页码，从1开始
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 当前页面记录数
		///</summary>
		
		private int? size_;
		
		///<summary>
		/// 当页数据列表
		///</summary>
		
		private List<com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel> dataList_;
		
		public int? GetTotalCount(){
			return this.totalCount_;
		}
		
		public void SetTotalCount(int? value){
			this.totalCount_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetSize(){
			return this.size_;
		}
		
		public void SetSize(int? value){
			this.size_ = value;
		}
		public List<com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel> GetDataList(){
			return this.dataList_;
		}
		
		public void SetDataList(List<com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel> value){
			this.dataList_ = value;
		}
		
	}
	
}