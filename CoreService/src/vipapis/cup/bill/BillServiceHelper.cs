using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.cup.bill{
	
	
	public class BillServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class updateBillInfo_args {
			
			///<summary>
			/// 对账单信息
			///</summary>
			
			private com.vip.vop.cup.api.bill.BillHeaderInfo bill_header_info_;
			
			public com.vip.vop.cup.api.bill.BillHeaderInfo GetBill_header_info(){
				return this.bill_header_info_;
			}
			
			public void SetBill_header_info(com.vip.vop.cup.api.bill.BillHeaderInfo value){
				this.bill_header_info_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.hermes.core.health.CheckResult success_;
			
			public com.vip.hermes.core.health.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.hermes.core.health.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateBillInfo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.bill.UpdateBillResult success_;
			
			public com.vip.vop.cup.api.bill.UpdateBillResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.bill.UpdateBillResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class healthCheck_argsHelper : TBeanSerializer<healthCheck_args>
		{
			
			public static healthCheck_argsHelper OBJ = new healthCheck_argsHelper();
			
			public static healthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateBillInfo_argsHelper : TBeanSerializer<updateBillInfo_args>
		{
			
			public static updateBillInfo_argsHelper OBJ = new updateBillInfo_argsHelper();
			
			public static updateBillInfo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateBillInfo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.bill.BillHeaderInfo value;
					
					value = new com.vip.vop.cup.api.bill.BillHeaderInfo();
					com.vip.vop.cup.api.bill.BillHeaderInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetBill_header_info(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateBillInfo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetBill_header_info() != null) {
					
					oprot.WriteFieldBegin("bill_header_info");
					
					com.vip.vop.cup.api.bill.BillHeaderInfoHelper.getInstance().Write(structs.GetBill_header_info(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("bill_header_info can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateBillInfo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_resultHelper : TBeanSerializer<healthCheck_result>
		{
			
			public static healthCheck_resultHelper OBJ = new healthCheck_resultHelper();
			
			public static healthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.hermes.core.health.CheckResult value;
					
					value = new com.vip.hermes.core.health.CheckResult();
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateBillInfo_resultHelper : TBeanSerializer<updateBillInfo_result>
		{
			
			public static updateBillInfo_resultHelper OBJ = new updateBillInfo_resultHelper();
			
			public static updateBillInfo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateBillInfo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.bill.UpdateBillResult value;
					
					value = new com.vip.vop.cup.api.bill.UpdateBillResult();
					com.vip.vop.cup.api.bill.UpdateBillResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateBillInfo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.bill.UpdateBillResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateBillInfo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class BillServiceClient : OspRestStub , BillService  {
			
			
			public BillServiceClient():base("vipapis.cup.bill.BillService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.hermes.core.health.CheckResult healthCheck() {
				
				send_healthCheck();
				return recv_healthCheck(); 
				
			}
			
			
			private void send_healthCheck(){
				
				InitInvocation("healthCheck");
				
				healthCheck_args args = new healthCheck_args();
				
				SendBase(args, healthCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.hermes.core.health.CheckResult recv_healthCheck(){
				
				healthCheck_result result = new healthCheck_result();
				ReceiveBase(result, healthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.bill.UpdateBillResult updateBillInfo(com.vip.vop.cup.api.bill.BillHeaderInfo bill_header_info_) {
				
				send_updateBillInfo(bill_header_info_);
				return recv_updateBillInfo(); 
				
			}
			
			
			private void send_updateBillInfo(com.vip.vop.cup.api.bill.BillHeaderInfo bill_header_info_){
				
				InitInvocation("updateBillInfo");
				
				updateBillInfo_args args = new updateBillInfo_args();
				args.SetBill_header_info(bill_header_info_);
				
				SendBase(args, updateBillInfo_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.bill.UpdateBillResult recv_updateBillInfo(){
				
				updateBillInfo_result result = new updateBillInfo_result();
				ReceiveBase(result, updateBillInfo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}