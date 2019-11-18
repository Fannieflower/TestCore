using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class PurchaseOrderModelResultHelper : TBeanSerializer<PurchaseOrderModelResult>
	{
		
		public static PurchaseOrderModelResultHelper OBJ = new PurchaseOrderModelResultHelper();
		
		public static PurchaseOrderModelResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PurchaseOrderModelResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("code".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCode(value);
					}
					
					
					
					
					
					if ("msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMsg(value);
					}
					
					
					
					
					
					if ("purchaseOrderModelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> value;
						
						value = new List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel elem0;
								
								elem0 = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel();
								com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPurchaseOrderModelList(value);
					}
					
					
					
					
					
					if ("pagination".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.cc.bulkbuying.model.PaginationModel value;
						
						value = new com.vip.xstore.cc.bulkbuying.model.PaginationModel();
						com.vip.xstore.cc.bulkbuying.model.PaginationModelHelper.getInstance().Read(value, iprot);
						
						structs.SetPagination(value);
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
		
		
		public void Write(PurchaseOrderModelResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCode() != null) {
				
				oprot.WriteFieldBegin("code");
				oprot.WriteI32((int)structs.GetCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMsg() != null) {
				
				oprot.WriteFieldBegin("msg");
				oprot.WriteString(structs.GetMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseOrderModelList() != null) {
				
				oprot.WriteFieldBegin("purchaseOrderModelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel _item0 in structs.GetPurchaseOrderModelList()){
					
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPagination() != null) {
				
				oprot.WriteFieldBegin("pagination");
				
				com.vip.xstore.cc.bulkbuying.model.PaginationModelHelper.getInstance().Write(structs.GetPagination(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PurchaseOrderModelResult bean){
			
			
		}
		
	}
	
}