using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.visPo.service{
	
	
	
	public class PoDetailDataHelper : TBeanSerializer<PoDetailData>
	{
		
		public static PoDetailDataHelper OBJ = new PoDetailDataHelper();
		
		public static PoDetailDataHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PoDetailData structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("poHeaderInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.venus.visPo.service.PoHeaderInfo value;
						
						value = new com.vip.venus.visPo.service.PoHeaderInfo();
						com.vip.venus.visPo.service.PoHeaderInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetPoHeaderInfo(value);
					}
					
					
					
					
					
					if ("poItemList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.venus.visPo.service.PoItem> value;
						
						value = new List<com.vip.venus.visPo.service.PoItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.venus.visPo.service.PoItem elem1;
								
								elem1 = new com.vip.venus.visPo.service.PoItem();
								com.vip.venus.visPo.service.PoItemHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPoItemList(value);
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
		
		
		public void Write(PoDetailData structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPoHeaderInfo() != null) {
				
				oprot.WriteFieldBegin("poHeaderInfo");
				
				com.vip.venus.visPo.service.PoHeaderInfoHelper.getInstance().Write(structs.GetPoHeaderInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoItemList() != null) {
				
				oprot.WriteFieldBegin("poItemList");
				
				oprot.WriteListBegin();
				foreach(com.vip.venus.visPo.service.PoItem _item0 in structs.GetPoItemList()){
					
					
					com.vip.venus.visPo.service.PoItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PoDetailData bean){
			
			
		}
		
	}
	
}