using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractAuditParams {
		
		///<summary>
		/// 确认函编号
		///</summary>
		
		private List<string> protNos_;
		
		///<summary>
		/// 审批操作（yes：通过，no：驳回）
		///</summary>
		
		private string isAgree_;
		
		///<summary>
		/// 驳回原因，isAgree=no时必填
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 确认函当前步骤（1:供应商,2:商务助理,3:商务经理,4:商务总监,5:特殊审批,6:确认）
		///</summary>
		
		private byte? stage_;
		
		///<summary>
		/// 审批人id
		///</summary>
		
		private int? createOperatorId_;
		
		///<summary>
		/// 品牌总货值列表
		///</summary>
		
		private List<com.vip.api.promotion.vis.protcontract.service.BrandGoods> brandGoodsList_;
		
		public List<string> GetProtNos(){
			return this.protNos_;
		}
		
		public void SetProtNos(List<string> value){
			this.protNos_ = value;
		}
		public string GetIsAgree(){
			return this.isAgree_;
		}
		
		public void SetIsAgree(string value){
			this.isAgree_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public byte? GetStage(){
			return this.stage_;
		}
		
		public void SetStage(byte? value){
			this.stage_ = value;
		}
		public int? GetCreateOperatorId(){
			return this.createOperatorId_;
		}
		
		public void SetCreateOperatorId(int? value){
			this.createOperatorId_ = value;
		}
		public List<com.vip.api.promotion.vis.protcontract.service.BrandGoods> GetBrandGoodsList(){
			return this.brandGoodsList_;
		}
		
		public void SetBrandGoodsList(List<com.vip.api.promotion.vis.protcontract.service.BrandGoods> value){
			this.brandGoodsList_ = value;
		}
		
	}
	
}