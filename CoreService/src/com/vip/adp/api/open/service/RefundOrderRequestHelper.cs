using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class RefundOrderRequestHelper : TBeanSerializer<RefundOrderRequest>
	{
		
		public static RefundOrderRequestHelper OBJ = new RefundOrderRequestHelper();
		
		public static RefundOrderRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RefundOrderRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("searchType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetSearchType(value);
					}
					
					
					
					
					
					if ("searchTimeStart".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSearchTimeStart(value);
					}
					
					
					
					
					
					if ("searchTimeEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSearchTimeEnd(value);
					}
					
					
					
					
					
					if ("orderSns".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrderSns(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
					}
					
					
					
					
					
					if ("requestId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRequestId(value);
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
		
		
		public void Write(RefundOrderRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSearchType() != null) {
				
				oprot.WriteFieldBegin("searchType");
				oprot.WriteI32((int)structs.GetSearchType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("searchType can not be null!");
			}
			
			
			if(structs.GetSearchTimeStart() != null) {
				
				oprot.WriteFieldBegin("searchTimeStart");
				oprot.WriteI64((long)structs.GetSearchTimeStart()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSearchTimeEnd() != null) {
				
				oprot.WriteFieldBegin("searchTimeEnd");
				oprot.WriteI64((long)structs.GetSearchTimeEnd()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSns() != null) {
				
				oprot.WriteFieldBegin("orderSns");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetOrderSns()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("page can not be null!");
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRequestId() != null) {
				
				oprot.WriteFieldBegin("requestId");
				oprot.WriteString(structs.GetRequestId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("requestId can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RefundOrderRequest bean){
			
			
		}
		
	}
	
}