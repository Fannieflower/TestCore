using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class BlacklistModelHelper : TBeanSerializer<BlacklistModel>
	{
		
		public static BlacklistModelHelper OBJ = new BlacklistModelHelper();
		
		public static BlacklistModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BlacklistModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("syncType".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.SyncType? value;
						
						value = com.vip.pms.data.service.SyncTypeUtil.FindByName(iprot.ReadString());
						
						structs.SetSyncType(value);
					}
					
					
					
					
					
					if ("blacklistIds".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								string elem1;
								elem1 = iprot.ReadString();
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetBlacklistIds(value);
					}
					
					
					
					
					
					if ("blackListType".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.BlackListType? value;
						
						value = com.vip.pms.data.service.BlackListTypeUtil.FindByName(iprot.ReadString());
						
						structs.SetBlackListType(value);
					}
					
					
					
					
					
					if ("salesModes".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<int?> value;
						
						value = new List<int?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								int elem2;
								elem2 = iprot.ReadI32(); 
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSalesModes(value);
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
		
		
		public void Write(BlacklistModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSyncType() != null) {
				
				oprot.WriteFieldBegin("syncType");
				oprot.WriteString(structs.GetSyncType().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("syncType can not be null!");
			}
			
			
			if(structs.GetBlacklistIds() != null) {
				
				oprot.WriteFieldBegin("blacklistIds");
				
				oprot.WriteSetBegin();
				foreach(string _item0 in structs.GetBlacklistIds()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("blacklistIds can not be null!");
			}
			
			
			if(structs.GetBlackListType() != null) {
				
				oprot.WriteFieldBegin("blackListType");
				oprot.WriteString(structs.GetBlackListType().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("blackListType can not be null!");
			}
			
			
			if(structs.GetSalesModes() != null) {
				
				oprot.WriteFieldBegin("salesModes");
				
				oprot.WriteListBegin();
				foreach(int _item0 in structs.GetSalesModes()){
					
					oprot.WriteI32((int)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BlacklistModel bean){
			
			
		}
		
	}
	
}