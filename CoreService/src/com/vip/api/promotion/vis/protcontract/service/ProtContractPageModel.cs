using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractPageModel {
		
		///<summary>
		/// 数据总数量
		///</summary>
		
		private int? totalCount_;
		
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
		public List<com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel> GetDataList(){
			return this.dataList_;
		}
		
		public void SetDataList(List<com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel> value){
			this.dataList_ = value;
		}
		
	}
	
}