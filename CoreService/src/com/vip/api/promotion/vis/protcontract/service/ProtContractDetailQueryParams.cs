using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractDetailQueryParams {
		
		///<summary>
		/// 分页查询参数
		///</summary>
		
		private com.vip.api.promotion.vis.common.Pager pager_;
		
		///<summary>
		/// 确认函列表详情参数
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParam protContractDetailQueryParam_;
		
		public com.vip.api.promotion.vis.common.Pager GetPager(){
			return this.pager_;
		}
		
		public void SetPager(com.vip.api.promotion.vis.common.Pager value){
			this.pager_ = value;
		}
		public com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParam GetProtContractDetailQueryParam(){
			return this.protContractDetailQueryParam_;
		}
		
		public void SetProtContractDetailQueryParam(com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParam value){
			this.protContractDetailQueryParam_ = value;
		}
		
	}
	
}