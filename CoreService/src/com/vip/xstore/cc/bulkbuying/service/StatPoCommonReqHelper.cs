using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class StatPoCommonReqHelper : TBeanSerializer<StatPoCommonReq>
	{
		
		public static StatPoCommonReqHelper OBJ = new StatPoCommonReqHelper();
		
		public static StatPoCommonReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(StatPoCommonReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("purchaseNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseNo(value);
					}
					
					
					
					
					
					if ("groupTypes".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.bulkbuying.service.StatPoGroupType?> value;
						
						value = new List<com.vip.xstore.cc.bulkbuying.service.StatPoGroupType?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.bulkbuying.service.StatPoGroupType? elem0;
								
								elem0 = com.vip.xstore.cc.bulkbuying.service.StatPoGroupTypeUtil.FindByName(iprot.ReadString());
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGroupTypes(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
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
		
		
		public void Write(StatPoCommonReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPurchaseNo() != null) {
				
				oprot.WriteFieldBegin("purchaseNo");
				oprot.WriteString(structs.GetPurchaseNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchaseNo can not be null!");
			}
			
			
			if(structs.GetGroupTypes() != null) {
				
				oprot.WriteFieldBegin("groupTypes");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.bulkbuying.service.StatPoGroupType? _item0 in structs.GetGroupTypes()){
					
					oprot.WriteString(_item0.ToString());  
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("groupTypes can not be null!");
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(StatPoCommonReq bean){
			
			
		}
		
	}
	
}