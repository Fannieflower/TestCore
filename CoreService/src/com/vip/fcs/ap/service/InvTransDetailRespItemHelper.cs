using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.ap.service{
	
	
	
	public class InvTransDetailRespItemHelper : TBeanSerializer<InvTransDetailRespItem>
	{
		
		public static InvTransDetailRespItemHelper OBJ = new InvTransDetailRespItemHelper();
		
		public static InvTransDetailRespItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InvTransDetailRespItem structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("count".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCount(value);
					}
					
					
					
					
					
					if ("invTransDetailReqItem".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.fcs.ap.service.InvTransDetailReqItem value;
						
						value = new com.vip.fcs.ap.service.InvTransDetailReqItem();
						com.vip.fcs.ap.service.InvTransDetailReqItemHelper.getInstance().Read(value, iprot);
						
						structs.SetInvTransDetailReqItem(value);
					}
					
					
					
					
					
					if ("invTransDetails".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.fcs.ap.service.InvTransDetail> value;
						
						value = new List<com.vip.fcs.ap.service.InvTransDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.fcs.ap.service.InvTransDetail elem1;
								
								elem1 = new com.vip.fcs.ap.service.InvTransDetail();
								com.vip.fcs.ap.service.InvTransDetailHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetInvTransDetails(value);
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
		
		
		public void Write(InvTransDetailRespItem structs, Protocol oprot){
			
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
			
			
			if(structs.GetCount() != null) {
				
				oprot.WriteFieldBegin("count");
				oprot.WriteI64((long)structs.GetCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvTransDetailReqItem() != null) {
				
				oprot.WriteFieldBegin("invTransDetailReqItem");
				
				com.vip.fcs.ap.service.InvTransDetailReqItemHelper.getInstance().Write(structs.GetInvTransDetailReqItem(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvTransDetails() != null) {
				
				oprot.WriteFieldBegin("invTransDetails");
				
				oprot.WriteListBegin();
				foreach(com.vip.fcs.ap.service.InvTransDetail _item0 in structs.GetInvTransDetails()){
					
					
					com.vip.fcs.ap.service.InvTransDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InvTransDetailRespItem bean){
			
			
		}
		
	}
	
}