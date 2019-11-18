using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class GetAscInfoResponse {
		
		///<summary>
		/// 售后申请单概要
		///</summary>
		
		private vipapis.marketplace.asc.AscBrief asc_brief_;
		
		///<summary>
		/// 退货原因
		///</summary>
		
		private string return_reason_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 承运商信息
		///</summary>
		
		private vipapis.marketplace.asc.TransportInfo transport_info_;
		
		///<summary>
		/// 退款信息
		///</summary>
		
		private vipapis.marketplace.asc.RefundInfo refund_info_;
		
		///<summary>
		/// 商品明细
		///</summary>
		
		private List<vipapis.marketplace.asc.AscProduct> asc_products_;
		
		///<summary>
		/// 包裹信息，承运商下可以有多个退货包裹
		///</summary>
		
		private List<string> package_tabs_;
		
		///<summary>
		/// 工单信息
		///</summary>
		
		private List<vipapis.marketplace.asc.ProblemOrder> problem_orders_;
		
		///<summary>
		/// 客退仓编码
		///</summary>
		
		private string return_warehouse_;
		
		public vipapis.marketplace.asc.AscBrief GetAsc_brief(){
			return this.asc_brief_;
		}
		
		public void SetAsc_brief(vipapis.marketplace.asc.AscBrief value){
			this.asc_brief_ = value;
		}
		public string GetReturn_reason(){
			return this.return_reason_;
		}
		
		public void SetReturn_reason(string value){
			this.return_reason_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public vipapis.marketplace.asc.TransportInfo GetTransport_info(){
			return this.transport_info_;
		}
		
		public void SetTransport_info(vipapis.marketplace.asc.TransportInfo value){
			this.transport_info_ = value;
		}
		public vipapis.marketplace.asc.RefundInfo GetRefund_info(){
			return this.refund_info_;
		}
		
		public void SetRefund_info(vipapis.marketplace.asc.RefundInfo value){
			this.refund_info_ = value;
		}
		public List<vipapis.marketplace.asc.AscProduct> GetAsc_products(){
			return this.asc_products_;
		}
		
		public void SetAsc_products(List<vipapis.marketplace.asc.AscProduct> value){
			this.asc_products_ = value;
		}
		public List<string> GetPackage_tabs(){
			return this.package_tabs_;
		}
		
		public void SetPackage_tabs(List<string> value){
			this.package_tabs_ = value;
		}
		public List<vipapis.marketplace.asc.ProblemOrder> GetProblem_orders(){
			return this.problem_orders_;
		}
		
		public void SetProblem_orders(List<vipapis.marketplace.asc.ProblemOrder> value){
			this.problem_orders_ = value;
		}
		public string GetReturn_warehouse(){
			return this.return_warehouse_;
		}
		
		public void SetReturn_warehouse(string value){
			this.return_warehouse_ = value;
		}
		
	}
	
}