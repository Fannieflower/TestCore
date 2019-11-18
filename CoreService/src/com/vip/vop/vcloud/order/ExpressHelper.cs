using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.order{
	
	
	
	public class ExpressHelper : TBeanSerializer<Express>
	{
		
		public static ExpressHelper OBJ = new ExpressHelper();
		
		public static ExpressHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Express structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("expressCompany".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpressCompany(value);
					}
					
					
					
					
					
					if ("expressNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpressNo(value);
					}
					
					
					
					
					
					if ("expressLists".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.vcloud.order.ExpressList> value;
						
						value = new List<com.vip.vop.vcloud.order.ExpressList>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.vcloud.order.ExpressList elem0;
								
								elem0 = new com.vip.vop.vcloud.order.ExpressList();
								com.vip.vop.vcloud.order.ExpressListHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetExpressLists(value);
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
		
		
		public void Write(Express structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetExpressCompany() != null) {
				
				oprot.WriteFieldBegin("expressCompany");
				oprot.WriteString(structs.GetExpressCompany());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpressNo() != null) {
				
				oprot.WriteFieldBegin("expressNo");
				oprot.WriteString(structs.GetExpressNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpressLists() != null) {
				
				oprot.WriteFieldBegin("expressLists");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.vcloud.order.ExpressList _item0 in structs.GetExpressLists()){
					
					
					com.vip.vop.vcloud.order.ExpressListHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Express bean){
			
			
		}
		
	}
	
}