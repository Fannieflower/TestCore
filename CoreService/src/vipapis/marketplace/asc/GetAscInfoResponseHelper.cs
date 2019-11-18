using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.asc{
	
	
	
	public class GetAscInfoResponseHelper : TBeanSerializer<GetAscInfoResponse>
	{
		
		public static GetAscInfoResponseHelper OBJ = new GetAscInfoResponseHelper();
		
		public static GetAscInfoResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetAscInfoResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("asc_brief".Equals(schemeField.Trim())){
						
						needSkip = false;
						vipapis.marketplace.asc.AscBrief value;
						
						value = new vipapis.marketplace.asc.AscBrief();
						vipapis.marketplace.asc.AscBriefHelper.getInstance().Read(value, iprot);
						
						structs.SetAsc_brief(value);
					}
					
					
					
					
					
					if ("return_reason".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturn_reason(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("transport_info".Equals(schemeField.Trim())){
						
						needSkip = false;
						vipapis.marketplace.asc.TransportInfo value;
						
						value = new vipapis.marketplace.asc.TransportInfo();
						vipapis.marketplace.asc.TransportInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetTransport_info(value);
					}
					
					
					
					
					
					if ("refund_info".Equals(schemeField.Trim())){
						
						needSkip = false;
						vipapis.marketplace.asc.RefundInfo value;
						
						value = new vipapis.marketplace.asc.RefundInfo();
						vipapis.marketplace.asc.RefundInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetRefund_info(value);
					}
					
					
					
					
					
					if ("asc_products".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.marketplace.asc.AscProduct> value;
						
						value = new List<vipapis.marketplace.asc.AscProduct>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.asc.AscProduct elem3;
								
								elem3 = new vipapis.marketplace.asc.AscProduct();
								vipapis.marketplace.asc.AscProductHelper.getInstance().Read(elem3, iprot);
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAsc_products(value);
					}
					
					
					
					
					
					if ("package_tabs".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem5;
								elem5 = iprot.ReadString();
								
								value.Add(elem5);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPackage_tabs(value);
					}
					
					
					
					
					
					if ("problem_orders".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.marketplace.asc.ProblemOrder> value;
						
						value = new List<vipapis.marketplace.asc.ProblemOrder>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.asc.ProblemOrder elem6;
								
								elem6 = new vipapis.marketplace.asc.ProblemOrder();
								vipapis.marketplace.asc.ProblemOrderHelper.getInstance().Read(elem6, iprot);
								
								value.Add(elem6);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetProblem_orders(value);
					}
					
					
					
					
					
					if ("return_warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturn_warehouse(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(GetAscInfoResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetAsc_brief() != null) {
				
				oprot.WriteFieldBegin("asc_brief");
				
				vipapis.marketplace.asc.AscBriefHelper.getInstance().Write(structs.GetAsc_brief(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("asc_brief can not be null!");
			}
			
			
			if(structs.GetReturn_reason() != null) {
				
				oprot.WriteFieldBegin("return_reason");
				oprot.WriteString(structs.GetReturn_reason());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransport_info() != null) {
				
				oprot.WriteFieldBegin("transport_info");
				
				vipapis.marketplace.asc.TransportInfoHelper.getInstance().Write(structs.GetTransport_info(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefund_info() != null) {
				
				oprot.WriteFieldBegin("refund_info");
				
				vipapis.marketplace.asc.RefundInfoHelper.getInstance().Write(structs.GetRefund_info(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAsc_products() != null) {
				
				oprot.WriteFieldBegin("asc_products");
				
				oprot.WriteListBegin();
				foreach(vipapis.marketplace.asc.AscProduct _item0 in structs.GetAsc_products()){
					
					
					vipapis.marketplace.asc.AscProductHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPackage_tabs() != null) {
				
				oprot.WriteFieldBegin("package_tabs");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetPackage_tabs()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProblem_orders() != null) {
				
				oprot.WriteFieldBegin("problem_orders");
				
				oprot.WriteListBegin();
				foreach(vipapis.marketplace.asc.ProblemOrder _item0 in structs.GetProblem_orders()){
					
					
					vipapis.marketplace.asc.ProblemOrderHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturn_warehouse() != null) {
				
				oprot.WriteFieldBegin("return_warehouse");
				oprot.WriteString(structs.GetReturn_warehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetAscInfoResponse bean){
			
			
		}
		
	}
	
}