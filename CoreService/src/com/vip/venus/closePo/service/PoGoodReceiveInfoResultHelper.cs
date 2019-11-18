using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.closePo.service{
	
	
	
	public class PoGoodReceiveInfoResultHelper : TBeanSerializer<PoGoodReceiveInfoResult>
	{
		
		public static PoGoodReceiveInfoResultHelper OBJ = new PoGoodReceiveInfoResultHelper();
		
		public static PoGoodReceiveInfoResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PoGoodReceiveInfoResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("po".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPo(value);
					}
					
					
					
					
					
					if ("itemRecQtyList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.venus.closePo.service.ItemReceiveInfo> value;
						
						value = new List<com.vip.venus.closePo.service.ItemReceiveInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.venus.closePo.service.ItemReceiveInfo elem0;
								
								elem0 = new com.vip.venus.closePo.service.ItemReceiveInfo();
								com.vip.venus.closePo.service.ItemReceiveInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItemRecQtyList(value);
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
		
		
		public void Write(PoGoodReceiveInfoResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPo() != null) {
				
				oprot.WriteFieldBegin("po");
				oprot.WriteString(structs.GetPo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItemRecQtyList() != null) {
				
				oprot.WriteFieldBegin("itemRecQtyList");
				
				oprot.WriteListBegin();
				foreach(com.vip.venus.closePo.service.ItemReceiveInfo _item0 in structs.GetItemRecQtyList()){
					
					
					com.vip.venus.closePo.service.ItemReceiveInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PoGoodReceiveInfoResult bean){
			
			
		}
		
	}
	
}